namespace DCACalculator.Data.Models;
public class Investment : EntityBase
{
    public DateTime Date { get; set; }
    public decimal InvestmentAmount { get; set; }
    public string? CryptoCurrencyName { get; set; }
    public double CryptoCurrencyAmount { get; set; }
}
