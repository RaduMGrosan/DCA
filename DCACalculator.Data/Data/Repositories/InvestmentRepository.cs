using DCACalculator.Data.Models;

namespace DCACalculator.Data.Data.Repositories;
public class InvestmentRepository(AppDbContext _db) : IInvestmentRepository
{
    public List<Investment> GetInvestments()
    {
        List<Investment> result = [];

        try
        {
            result = (from investment in _db.Investment
                      orderby investment.Date ascending
                      select investment).ToList();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }

        return result;
    }

    public async Task<bool> AddInvestmentAsync(Investment investment)
    {
        _db.Investment.Add(investment);
        try {
            await _db.SaveChangesAsync();
            return true;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return false;
        }
    }
}
