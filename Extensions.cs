using System.Globalization;
using System.Net.WebSockets;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;

namespace Stella
{
    public static class Extensions
    {
        public static string ToPascalCase(this string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return str;
            }

            var words = str.Split([' ', '_'], StringSplitOptions.RemoveEmptyEntries);

            if (words.Length == 0)
            {
                return string.Empty;
            }

            string firstWord = words[0].ToUpperInvariant();

            var subsequentWords = words.Skip(1).Select(word => CultureInfo.InvariantCulture.TextInfo.ToTitleCase(word.ToLowerInvariant()));

            return firstWord + string.Join(string.Empty, subsequentWords);
        }

        public static string ToCamelCase(this string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return str;
            }

            var words = str.Split([' ', '_'], StringSplitOptions.RemoveEmptyEntries);

            if (words.Length == 0)
            {
                return string.Empty;
            }

            string firstWord = words[0].ToLowerInvariant();

            var subsequentWords = words.Skip(1).Select(word => CultureInfo.InvariantCulture.TextInfo.ToTitleCase(word.ToLowerInvariant()));

            return firstWord + string.Join(string.Empty, subsequentWords);
        }

        public static long ToUnixTime(this DateTime dateTime)
        {
            TimeSpan sinceEpoch = dateTime - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            
            return (long)sinceEpoch.TotalSeconds;
        }

        public static async Task<string> GetJson(this HttpRequest request)
        {
            if (request.HttpContext.Items.TryGetValue("__body__", out var cached) && cached is string json)
                return json;

            request.EnableBuffering();

            using var reader = new StreamReader(request.Body, Encoding.UTF8, leaveOpen: true);
            json = await reader.ReadToEndAsync();

            request.Body.Position = 0;

            request.HttpContext.Items["__body__"] = json;

            return json;
        }

        public static async Task<T?> GetJson<T>(this HttpRequest request)
        {
            string json = await request.GetJson();

            if (string.IsNullOrWhiteSpace(json))
                return default;

            return JsonSerializer.Deserialize<T>(json, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
        }

        public static Task SendAsync(this WebSocket ws, string buffer, WebSocketMessageType messageType, bool endOfMessage, CancellationToken cancellationToken)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(buffer);
            return ws.SendAsync(bytes, messageType, endOfMessage, cancellationToken);
        }
        
        public static string ToMD5(this string str)
        {
            byte[] bytes = MD5.HashData(Encoding.UTF8.GetBytes(str));

            StringBuilder builder = new();
            for (int i = 0; i < bytes.Length; i++)
            {
                builder.Append(bytes[i].ToString("x2"));
            }
            return builder.ToString();
        }
        
        public static string ToSHA1(this string str)
        {
            byte[] bytes = SHA1.HashData(Encoding.UTF8.GetBytes(str));

            StringBuilder builder = new();
            for (int i = 0; i < bytes.Length; i++)
            {
                builder.Append(bytes[i].ToString("x2"));
            }
            return builder.ToString();
        }
        
        public static string ToSHA256(this string str)
        {
            byte[] bytes = SHA256.HashData(Encoding.UTF8.GetBytes(str));

            StringBuilder builder = new();
            for (int i = 0; i < bytes.Length; i++)
            {
                builder.Append(bytes[i].ToString("x2"));
            }
            return builder.ToString();
        }
        
        public static string ToSHA384(this string str)
        {
            byte[] bytes = SHA384.HashData(Encoding.UTF8.GetBytes(str));

            StringBuilder builder = new();
            for (int i = 0; i < bytes.Length; i++)
            {
                builder.Append(bytes[i].ToString("x2"));
            }
            return builder.ToString();
        }
        
        public static string ToSHA512(this string str)
        {
            byte[] bytes = SHA512.HashData(Encoding.UTF8.GetBytes(str));

            StringBuilder builder = new();
            for (int i = 0; i < bytes.Length; i++)
            {
                builder.Append(bytes[i].ToString("x2"));
            }
            return builder.ToString();
        }
    }
}