using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using Devdraft.Client;
using Devdraft.Api;
using Devdraft.Model;

namespace Devdraft.Examples
{
    /// <summary>
    /// Invoice Examples
    /// </summary>
    public class InvoicesExample
    {
        public static async Task SimpleCreateInvoice()
        {
            var configuration = new Configuration();
            
            var clientKey = Environment.GetEnvironmentVariable("CLIENT_KEY") ?? "your-client-key";
            var clientSecret = Environment.GetEnvironmentVariable("CLIENT_SECRET") ?? "your-client-secret";
            
            configuration.DefaultHeaders.Add("x-client-key", clientKey);
            configuration.DefaultHeaders.Add("x-client-secret", clientSecret);
            
            var apiInstance = new InvoicesApi(configuration);
            
            var invoiceData = new CreateInvoiceDto
            {
                CustomerId = "cus_12345",
                Products = new List<InvoiceProductDto>
                {
                    new InvoiceProductDto
                    {
                        ProductId = "prod_123",
                        Quantity = 2,
                        Price = 99.99m
                    }
                }
            };
            
            try
            {
                var invoice = await apiInstance.InvoiceControllerCreateAsync(invoiceData);
                Console.WriteLine($"Invoice created: {invoice.Id}");
            }
            catch (ApiException e)
            {
                Console.WriteLine($"Invoice creation failed: {e.Message}");
            }
        }
        
        public static async Task Main(string[] args)
        {
            await SimpleCreateInvoice();
        }
    }
}
