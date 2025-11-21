using System;
using System.Threading.Tasks;
using Devdraft.Client;
using Devdraft.Api;
using Devdraft.Model;

namespace Devdraft.Examples
{
    /// <summary>
    /// Customer Examples
    /// </summary>
    public class CustomersExample
    {
        public static async Task SimpleCreateCustomer()
        {
            var configuration = new Configuration();
            
            var clientKey = Environment.GetEnvironmentVariable("CLIENT_KEY") ?? "your-client-key";
            var clientSecret = Environment.GetEnvironmentVariable("CLIENT_SECRET") ?? "your-client-secret";
            
            configuration.DefaultHeaders.Add("x-client-key", clientKey);
            configuration.DefaultHeaders.Add("x-client-secret", clientSecret);
            
            var apiInstance = new CustomersApi(configuration);
            
            var customerData = new CreateCustomerDto
            {
                FirstName = "John",
                LastName = "Doe",
                Email = "john.doe@example.com",
                PhoneNumber = "+1-555-123-4567",
                CustomerType = CustomerType.Startup,
                Status = CustomerStatus.Active
            };
            
            try
            {
                var customer = await apiInstance.CustomerControllerCreateAsync(customerData);
                Console.WriteLine($"Customer created: {customer.Id}");
            }
            catch (ApiException e)
            {
                Console.WriteLine($"Customer creation failed: {e.Message}");
            }
        }
        
        public static async Task Main(string[] args)
        {
            await SimpleCreateCustomer();
        }
    }
}
