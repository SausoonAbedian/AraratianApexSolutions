namespace AraratianApexSolutions.LeetCodeTracker.Services;

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AraratianApexSolutions.LeetCodeTracker.Models;
using Microsoft.EntityFrameworkCore;

public class DataAccessService(LeetCodeTrackerDbContext context)
{
    public async Task<List<Question>> GetQuestionsAsync()
    {
        return await context.Questions.OrderBy(a => a.Number).ToListAsync();
    }
}
