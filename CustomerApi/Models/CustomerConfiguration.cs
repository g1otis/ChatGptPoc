using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CustomerApi.Models;

public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
{
    public void Configure(EntityTypeBuilder<Customer> builder)
    {
        // Configure complex type Origin as required
        builder.OwnsOne(c => c.Origin, o =>
        {
            o.Property(x => x.DateOfBirth).IsRequired();
            o.Property(x => x.CountryOfBirth).IsRequired();
            o.Property(x => x.Gender).IsRequired();
        });

        // Configure complex type Address as required
        builder.OwnsOne(c => c.Address, a =>
        {
            a.Property(x => x.StreetName).IsRequired();
            a.Property(x => x.StreetNumber).IsRequired();
            a.Property(x => x.PostalCode).IsRequired();
            a.Property(x => x.CountryCode).IsRequired();
            a.Property(x => x.City).IsRequired();
        });

        // Configure the collection of Telephones with Customer
        builder.HasMany(c => c.Telephones)
               .WithOne(t => t.Customer)
               .HasForeignKey(t => t.CustomerId);
    }
}