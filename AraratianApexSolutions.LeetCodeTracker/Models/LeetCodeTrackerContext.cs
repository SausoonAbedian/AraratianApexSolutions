namespace AraratianApexSolutions.LeetCodeTracker.Models;

using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.EntityFrameworkCore;

public class LeetCodeTrackerContext : DbContext
{
    public DbSet<Question> Questions { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string databasePath = Path.Combine(Directory.GetCurrentDirectory(), "Database", "LeetCodeTrackerDb.mdf");

        optionsBuilder.UseSqlServer($@"Server=(localdb)\mssqllocaldb;AttachDbFilename={databasePath};Database=LeetCodeTrackerDb;Trusted_Connection=True;");
    }

}
