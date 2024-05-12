using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CustomerApi.Models;

public class TelephoneConfiguration : IEntityTypeConfiguration<Telephone>
{
    public void Configure(EntityTypeBuilder<Telephone> builder)
    {
        builder.Property(t => t.TelCountryExtension).IsRequired();
        builder.Property(t => t.TelNumber).IsRequired();
        builder.Property(t => t.Type).IsRequired(); // Assuming Type is an enum, EF will handle it accordingly

        // If Type is a string and you want to constrain the values (e.g., Home, Mobile, Work),
        // you might need additional configuration or handling elsewhere, as EF Core doesn't directly enforce enum strings.
    }
}
