using DCACalculator.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DCACalculator.Data.Data.Config;
public class InvestmentConfiguration : IEntityTypeConfiguration<Investment>
{
    public void Configure(EntityTypeBuilder<Investment> builder) {
        builder.Property(p => p.Date)
            .IsRequired();

        builder.Property(p => p.InvestmentAmount)
            .IsRequired();

        builder.Property(p => p.CryptoCurrencyName)
            .IsRequired();

        builder.Property(p => p.CryptoCurrencyAmount)
            .IsRequired();
    }
}
