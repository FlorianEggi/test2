using Microsoft.AspNetCore.Blazor.Hosting;
using System.Threading.Tasks;

namespace Webshop
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
           // var builder = WebAssemblyHostBuilder.CreateDefault(args);

             CreateHostBuilder(args).Build().Run();
            //await builder.Build().RunAsync();

        }

        public static IWebAssemblyHostBuilder CreateHostBuilder(string[] args) =>
            BlazorWebAssemblyHost.CreateDefaultBuilder()
                .UseBlazorStartup<Startup>();
    }
}
