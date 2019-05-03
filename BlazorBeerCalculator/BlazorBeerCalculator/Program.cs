using Microsoft.AspNetCore.Blazor.Hosting;

namespace BlazorBeerCalculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            BlazorWebAssemblyHost.CreateDefaultBuilder()
                                 .UseBlazorStartup<Startup>()
                                 .Build()
                                 .Run();
        }
    }
}