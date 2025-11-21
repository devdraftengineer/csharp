using System;
using System.Threading.Tasks;
using Devdraft.Client;
using Devdraft.Api;
using Devdraft.Model;

namespace Devdraft.Examples
{
    /// <summary>
    /// Health Check Examples
    /// 
    /// These examples demonstrate how to use the health check endpoints.
    /// </summary>
    public class HealthCheckExample
    {
        // ============================================================================
        // Simple Example: Public Health Check
        // ============================================================================
        
        public static async Task SimplePublicHealthCheck()
        {
            var configuration = new Configuration();
            var apiInstance = new APIHealthApi(configuration);
            
            try
            {
                var response = await apiInstance.HealthControllerPublicHealthCheckV0Async();
                Console.WriteLine($"Service status: {response.Status}");
                Console.WriteLine($"Service is healthy: {response.Status == "ok"}");
            }
            catch (ApiException e)
            {
                Console.WriteLine($"Health check failed: {e.Message}");
            }
        }
        
        // ============================================================================
        // Advanced Example: Authenticated Health Check with Error Handling
        // ============================================================================
        
        public static async Task AdvancedAuthenticatedHealthCheck()
        {
            var configuration = new Configuration();
            
            // Configure API key authorization
            var clientKey = Environment.GetEnvironmentVariable("CLIENT_KEY") ?? "your-client-key";
            var clientSecret = Environment.GetEnvironmentVariable("CLIENT_SECRET") ?? "your-client-secret";
            
            configuration.DefaultHeaders.Add("x-client-key", clientKey);
            configuration.DefaultHeaders.Add("x-client-secret", clientSecret);
            
            var apiInstance = new APIHealthApi(configuration);
            
            try
            {
                var response = await apiInstance.HealthControllerCheckV0Async();
                
                Console.WriteLine("=== Health Check Results ===");
                Console.WriteLine($"Status: {response.Status}");
                Console.WriteLine($"Version: {response.Version}");
                Console.WriteLine($"Database: {response.Database}");
                Console.WriteLine($"Message: {response.Message}");
                Console.WriteLine($"Authenticated: {response.Authenticated}");
                Console.WriteLine($"Timestamp: {response.Timestamp}");
                
                // Check if service is healthy
                if (response.Status == "ok" && response.Database == "connected")
                {
                    Console.WriteLine("✅ Service is fully operational");
                }
                else
                {
                    Console.WriteLine("⚠️  Service may have issues");
                }
            }
            catch (ApiException e)
            {
                if (e.StatusCode == 401)
                {
                    Console.WriteLine("❌ Authentication failed. Please check your API keys.");
                }
                else
                {
                    Console.WriteLine($"❌ Request failed: {e.Message}");
                }
            }
        }
        
        // ============================================================================
        // Error Scenario: Handling Authentication Errors
        // ============================================================================
        
        public static async Task ErrorScenarioHealthCheck()
        {
            var configuration = new Configuration();
            
            // Intentionally wrong API key
            configuration.DefaultHeaders.Add("x-client-key", "invalid-key");
            configuration.DefaultHeaders.Add("x-client-secret", "invalid-secret");
            
            var apiInstance = new APIHealthApi(configuration);
            
            try
            {
                await apiInstance.HealthControllerCheckV0Async();
            }
            catch (ApiException e)
            {
                if (e.StatusCode == 401)
                {
                    Console.WriteLine("❌ Unauthorized: Invalid API credentials");
                    Console.WriteLine("Please verify your CLIENT_KEY and CLIENT_SECRET environment variables");
                }
                else if (e.StatusCode == 429)
                {
                    Console.WriteLine("❌ Rate limit exceeded. Please wait before retrying.");
                }
                else
                {
                    Console.WriteLine($"❌ Unexpected error: {e.Message}");
                }
            }
        }
        
        public static async Task Main(string[] args)
        {
            await SimplePublicHealthCheck();
            await AdvancedAuthenticatedHealthCheck();
        }
    }
}
