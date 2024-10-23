using DCACalculator.Data.Models;

namespace DCACalculator.Data.Data.Models;
public class Plan : EntityBase
{
    public DateTime? StartDate { get; set; }
    public decimal Investment { get; set; }
    public string? Period { get; set; }
    public string? CryptoCurrencyName { get; set; }

    public Plan() {
        StartDate = DateTime.MinValue;
    }
}
