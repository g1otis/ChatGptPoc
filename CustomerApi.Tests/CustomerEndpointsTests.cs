using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using CustomerApi.Data;
using Microsoft.AspNetCore.Hosting;
using CustomerApi.Models;

namespace CustomerApi.Tests
{
    public class CustomerEndpointsTests
    {
        private HttpClient _client = null!;

        [SetUp]
        public void Setup()
        {
            // Create an instance of the WebApplicationFactory with a customized configuration
            var appFactory = new WebApplicationFactory<Program>()
                .WithWebHostBuilder(builder =>
                {
                    builder.ConfigureServices(services =>
                    {
                        // Find the descriptor for the DbContext and remove it
                        var descriptor = services.SingleOrDefault(
                            d => d.ServiceType == typeof(DbContextOptions<CustomerContext>));
                        if (descriptor != null)
                        {
                            services.Remove(descriptor);
                        }

                        // Add DbContext with InMemoryDatabase for testing
                        services.AddDbContext<CustomerContext>(options =>
                        {
                            options.UseInMemoryDatabase("TestDbForEndpoints");
                        });

                        // It's possible to add additional mock services here if needed
                    });

                    builder.UseEnvironment("UnitTesting");
                });

            using (var scope = appFactory.Services.CreateScope())
            {
                var scopedServices = scope.ServiceProvider;
                var db = scopedServices.GetRequiredService<CustomerContext>();
                db.Database.EnsureCreated();
                InitializeDbForTests(db);
            }

            _client = appFactory.CreateClient();
        }

        private static void InitializeDbForTests(CustomerContext db)
        {
            db.Customers.Add(new Customer { Id = 1, Name = "John Doe", Email = "john@example.com" });
            db.SaveChanges();
        }

        [Test]
        public async Task Get_Customer_ReturnsSuccessStatusCode()
        {
            // Assuming "/api/customers/1" is a valid endpoint in your actual API
            var response = await _client.GetAsync("/customers/1");

            Assert.That(response.IsSuccessStatusCode);
        }
    }
}