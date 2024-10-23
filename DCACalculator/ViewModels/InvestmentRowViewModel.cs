namespace DCACalculator.ViewModels;
public class InvestmentRowViewModel
{
    public long Id { get; set; }
    public DateTime Date { get; set; }
    public decimal InvestmentAmount { get; set; }
    public string? CryptoCurrencyName { get; set; }
    public double CryptoCurrencyAmount { get; set; }
    public decimal ValueToday { get; set; }
    public decimal ROI { get; set; } 
}
