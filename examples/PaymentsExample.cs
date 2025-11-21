using System;
using System.Threading.Tasks;
using Devdraft.Client;
using Devdraft.Api;
using Devdraft.Model;

namespace Devdraft.Examples
{
    /// <summary>
    /// Payment Examples
    /// </summary>
    public class PaymentsExample
    {
        public static async Task SimpleCreatePayment()
        {
            var configuration = new Configuration();
            
            var clientKey = Environment.GetEnvironmentVariable("CLIENT_KEY") ?? "your-client-key";
            var clientSecret = Environment.GetEnvironmentVariable("CLIENT_SECRET") ?? "your-client-secret";
            
            configuration.DefaultHeaders.Add("x-client-key", clientKey);
            configuration.DefaultHeaders.Add("x-client-secret", clientSecret);
            
            var apiInstance = new TestPaymentsApi(configuration);
            
            var paymentRequest = new PaymentRequestDto
            {
                Amount = 100.50f,
                Currency = "USD",
                Description = "Test payment for order #12345",
                CustomerId = "cus_12345"
            };
            
            var idempotencyKey = $"payment_{Guid.NewGuid()}";
            
            try
            {
                var response = await apiInstance.TestPaymentControllerCreatePaymentV0Async(
                    idempotencyKey, 
                    paymentRequest
                );
                Console.WriteLine($"Payment created: {response.Id}");
                Console.WriteLine($"Status: {response.Status}");
            }
            catch (ApiException e)
            {
                Console.WriteLine($"Payment creation failed: {e.Message}");
            }
        }
        
        public static async Task Main(string[] args)
        {
            await SimpleCreatePayment();
        }
    }
}
