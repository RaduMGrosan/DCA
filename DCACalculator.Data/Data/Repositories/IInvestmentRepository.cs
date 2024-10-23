using DCACalculator.Data.Models;

namespace DCACalculator.Data.Data.Repositories;

public interface IInvestmentRepository
{
    List<Investment> GetInvestments();
    Task<bool> AddInvestmentAsync(Investment investment);
}
