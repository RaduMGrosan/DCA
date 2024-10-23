using DCACalculator.Data.Data.Models;

namespace DCACalculator.Data.Data.Repositories;
public interface IPlanRepository
{
    List<Plan> GetPlans();
    Task<bool> AddPlanAsync(Plan plan);
}
