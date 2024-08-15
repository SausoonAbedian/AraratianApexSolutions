namespace AraratianApexSolutions.LeetCodeTracker.Web;

using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
internal class Program
{
    static async Task Main(string[] args)
    {
        var builder = WebAssemblyHostBuilder.CreateDefault(args);

        await builder.Build().RunAsync();
    }
}
