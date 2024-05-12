using Microsoft.EntityFrameworkCore;
using CustomerApi.Models;

namespace CustomerApi.Data;

public class CustomerContext : DbContext
{
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Telephone> Telephones { get; set; }

    public CustomerContext(DbContextOptions<CustomerContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Apply configurations
        modelBuilder.ApplyConfiguration(new CustomerConfiguration());
        modelBuilder.ApplyConfiguration(new TelephoneConfiguration());

        // Alternatively, to automatically apply all IEntityTypeConfiguration instances in the assembly:
        // modelBuilder.ApplyConfigurationsFromAssembly(typeof(CustomerContext).Assembly);
    }
}
