using Microsoft.AspNetCore.Mvc.ModelBinding;
using MongoDB.Driver.Core.Connections;
using Stella.Models;
using System.Net.WebSockets;
using System.Text;
using System.Text.Json;

namespace Stella.Routes
{
    public class NotificationHub
    {
        private static readonly Dictionary<long, WebSocket> Connections = [];

        [ServerAPI.POST("/notify/hub/v1/negotiate")]
        public async Task Negotiate(HttpContext ctx)
        {
            var response = new
            {
                negotiateVersion = 0,
                accessToken = JsonWebToken.Generate(new() {
                    { "sub", "1" },
                    { "role", "client" },
                    { "iat", DateTime.UtcNow.ToUnixTime() }
                }, TimeSpan.FromSeconds(6)),
                availableTransports = new[]
                {
                    new {
                        transport = "WebSockets",
                        transferFormats = new[] {
                            "Text"
                        }
                    }
                }
            };

            ctx.Response.ContentType = "application/json";
            await ctx.Response.WriteAsync(JsonSerializer.Serialize(response));
        }

        [ServerAPI.MAP("/notify/hub/v1")]
        [ServerAPI.UseAuthorization]
        public async Task SignalR(HttpContext ctx, MongoDB.User user)
        {
            IDictionary<string, object>? info = JsonWebToken.VerifyAndDecode(ctx.Request.Headers.Authorization);
            if (info == null)
            {
                return;
            }

            using WebSocket ws = await ctx.WebSockets.AcceptWebSocketAsync();
            Connections[user.AccountId] = ws;

            byte[] buffer = new byte[4096];

            try
            {
                while (ws.State == WebSocketState.Open)
                {
                    WebSocketReceiveResult r = await ws.ReceiveAsync(buffer, CancellationToken.None);

                    if (r.MessageType == WebSocketMessageType.Close)
                        break;

                    string msg = Encoding.UTF8.GetString(buffer, 0, r.Count);

                    if (!msg.EndsWith("\x1E"))
                        break;

                    msg = msg[..^1]; // remove the \x1E

                    using var doc = JsonDocument.Parse(msg);

                    var root = doc.RootElement;

                    if (root.TryGetProperty("protocol", out _))
                    {
                        byte[] bytes = Encoding.UTF8.GetBytes("{}\x1E");
                        await ws.SendAsync(bytes, WebSocketMessageType.Text, true, CancellationToken.None);
                        continue;
                    }

                    if (root.TryGetProperty("type", out var t) && t.GetInt32() == 6)
                    {
                        byte[] bytes = Encoding.UTF8.GetBytes("{\"type\":6}\x1E");
                        await ws.SendAsync(bytes, WebSocketMessageType.Text, true, CancellationToken.None);
                        continue;
                    }
                }
            }
            finally
            {
                Connections.Remove(user.AccountId);
            }
        }

        public static async Task SendWebsocket(long id, object json)
        {
            if (!Connections.TryGetValue(id, out var ws))
            {
                Console.WriteLine(id);
                return;
            }

            if (ws.State != WebSocketState.Open)
                return;

            string inner = JsonSerializer.Serialize(json).Replace("\"", "\\u0022");

            string outMessage = $"{{\"type\":1,\"invocationId\":\"{id}\",\"nonblocking\":true,\"target\":\"Notification\",\"arguments\":[\"{inner}\"],\"item\":\"\",\"result\":\"200 OK\",\"error\":\"\"}}\x1E";

            await ws.SendAsync(outMessage, WebSocketMessageType.Text, true, CancellationToken.None);
        }

        public static async Task SendWebsocket(object json)
        {
            foreach (var kvp in Connections)
            {
                var ws = kvp.Value;

                if (ws.State != WebSocketState.Open)
                    continue;

                string inner = JsonSerializer.Serialize(json).Replace("\"", "\\u0022");
                
                string outMessage = $"{{\"type\":1,\"invocationId\":\"{kvp.Key}\",\"nonblocking\":true,\"target\":\"Notification\",\"arguments\":[\"{inner}\"],\"item\":\"\",\"result\":\"200 OK\",\"error\":\"\"}}\x1E";

                await ws.SendAsync(outMessage, WebSocketMessageType.Text, true, CancellationToken.None);
            }
        }
    }
}