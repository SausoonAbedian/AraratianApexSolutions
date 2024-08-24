namespace AraratianApexSolutions.LeetCodeTracker.Models;

using Microsoft.EntityFrameworkCore;

public class LeetCodeTrackerDbContext(DbContextOptions<LeetCodeTrackerDbContext> options) : DbContext(options)
{
    public DbSet<Question> Questions { get; set; }
}
