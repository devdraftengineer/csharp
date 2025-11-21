using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using Devdraft.Client;
using Devdraft.Api;
using Devdraft.Model;

namespace Devdraft.Examples
{
    /// <summary>
    /// Webhook Examples
    /// </summary>
    public class WebhooksExample
    {
        public static async Task SimpleCreateWebhook()
        {
            var configuration = new Configuration();
            
            var clientKey = Environment.GetEnvironmentVariable("CLIENT_KEY") ?? "your-client-key";
            var clientSecret = Environment.GetEnvironmentVariable("CLIENT_SECRET") ?? "your-client-secret";
            
            configuration.DefaultHeaders.Add("x-client-key", clientKey);
            configuration.DefaultHeaders.Add("x-client-secret", clientSecret);
            
            var apiInstance = new WebhooksApi(configuration);
            
            var webhookData = new CreateWebhookDto
            {
                Url = "https://your-app.com/webhooks/payment",
                Events = new List<string> { "payment.created", "payment.succeeded" }
            };
            
            try
            {
                var webhook = await apiInstance.WebhookControllerCreateAsync(webhookData);
                Console.WriteLine($"Webhook created: {webhook.Id}");
                Console.WriteLine($"Webhook URL: {webhook.Url}");
            }
            catch (ApiException e)
            {
                Console.WriteLine($"Webhook creation failed: {e.Message}");
            }
        }
        
        public static async Task Main(string[] args)
        {
            await SimpleCreateWebhook();
        }
    }
}
