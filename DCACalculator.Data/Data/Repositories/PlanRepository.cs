using DCACalculator.Data.Data.Models;

namespace DCACalculator.Data.Data.Repositories;
public class PlanRepository(AppDbContext _db) : IPlanRepository
{
    public List<Plan> GetPlans() 
    {
        List<Plan> result = [];

        try {
            result = (from plan in _db.Plan 
                     orderby plan.StartDate ascending
                     select plan).ToList();
        }
        catch (Exception e) {
            Console.WriteLine(e);
        }

        return result;
    }

    public async Task<bool> AddPlanAsync(Plan plan)
    {
        _db.Plan.Add(plan);
        try
        {
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
