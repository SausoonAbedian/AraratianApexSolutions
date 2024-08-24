namespace AraratianApexSolutions.LeetCodeTracker;

using System.IO;

using AraratianApexSolutions.LeetCodeTracker.Components;
using AraratianApexSolutions.LeetCodeTracker.Models;
using AraratianApexSolutions.LeetCodeTracker.Services;

using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

public class Program
{
    public static readonly string dbConnectionString = $@"Server=(localdb)\mssqllocaldb;AttachDbFilename={Path.Combine(Directory.GetCurrentDirectory(), "Database", "LeetCodeTrackerDb.mdf")};Database=LeetCodeTrackerDb;Trusted_Connection=True;";

    public static void Main(string[] args)
    {
        WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

        builder.Services.AddRazorComponents().AddInteractiveServerComponents();
        builder.Services.AddDbContext<LeetCodeTrackerDbContext>(options => options.UseSqlServer(dbConnectionString));
        builder.Services.AddScoped(typeof(DataAccessService));

        WebApplication app = builder.Build();

        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Error");
            app.UseHsts();
        }

        app.UseHttpsRedirection();

        app.UseStaticFiles();
        app.UseAntiforgery();

        app.MapRazorComponents<App>().AddInteractiveServerRenderMode();

        app.Run();
    }
}
