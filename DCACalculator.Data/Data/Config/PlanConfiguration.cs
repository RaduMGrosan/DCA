using DCACalculator.Data.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DCACalculator.Data.Data.Config;
public class PlanConfiguration : IEntityTypeConfiguration<Plan>
{
    public void Configure(EntityTypeBuilder<Plan> builder) {
        builder.Property(p => p.StartDate)
            .IsRequired();

        builder.Property(p => p.Investment)
            .IsRequired();

        builder.Property(p => p.CryptoCurrencyName)
            .IsRequired();

        builder.Property(p => p.Period)
            .IsRequired();
    }
}
