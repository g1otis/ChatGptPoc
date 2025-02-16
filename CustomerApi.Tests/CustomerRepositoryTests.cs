// CustomerRepositoryTests.cs
using NUnit.Framework;
using Microsoft.EntityFrameworkCore;
using CustomerApi.Data;
using CustomerApi.Repositories;
using System.Threading.Tasks;
using CustomerApi.Models;  // Ensure your Customer model is correctly referenced

namespace CustomerApi.Tests
{
    public class CustomerRepositoryTests
    {
        private CustomerContext _context;

        [SetUp]
        public void Setup()
        {
            var options = new DbContextOptionsBuilder<CustomerContext>()
                .UseInMemoryDatabase(databaseName: "TestDb")
                .Options;
            _context = new CustomerContext(options);
            _context.Database.EnsureCreated();
        }

        [TearDown]
        public void TearDown()
        {
            _context.Database.EnsureDeleted();
            _context.Dispose();
        }

        [Test]
        public async Task GetCustomerById_WhenCustomerExists_ReturnsCustomer()
        {
            var repository = new CustomerRepository(_context);
            // Make sure to include all required fields as per your Customer entity definition
            var customer = new Customer { Id = 1, Name = "John Doe", Email = "john.doe@example.com" };
            await _context.Customers.AddAsync(customer);
            await _context.SaveChangesAsync();

            var result = await repository.GetByIdAsync(1);

            Assert.IsNotNull(result);
            Assert.AreEqual("John Doe", result.Name);
            Assert.AreEqual("john.doe@example.com", result.Email); // Verifying the email is correctly set and retrieved
        }
    }
}
