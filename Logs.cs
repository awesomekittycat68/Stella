using System.Text;
using System.Text.Json;

namespace Stella
{
    public static class Logs
    {
        private static readonly string webhookUrl = "i'm not that mean";

        public static async Task SendWebhookAsync(string imageName, string? uploadedBy, string? roomName)
        {
            var payload = new
            {
                content = (string?)null,
                embeds = new[]
                {
                    new
                    {
                        description = $"Uploaded by @{uploadedBy}\n\nRoom: {roomName}",
                        color = 16416882,
                        image = new
                        {
                            url = $"https://ns.stellaonline.org/img/{imageName}"
                        },
                        timestamp = DateTime.UtcNow.ToString("o")
                    }
                }, 
                attachments = Array.Empty<object>()
            };

            var json = JsonSerializer.Serialize(payload);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            using HttpClient client = new();
            var response = await client.PostAsync(webhookUrl, content);

            if (!response.IsSuccessStatusCode)
            {
                Console.WriteLine($"Failed to send webhook: {response.StatusCode}");
            }
        }
    }
}