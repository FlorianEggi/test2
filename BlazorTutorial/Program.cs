using Microsoft.AspNetCore.Blazor.Hosting;
using Microsoft.AspNetCore.Blazor.Http;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;
using Webshop.Shared.Services;

namespace Webshop
{
    public class Program
    {

        private const string url = "https://www.online.holter.at";
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.Services.AddScoped<AuthenticationService>(s =>
            {
                return new AuthenticationService(url);
            });

            var corsAttr = new Microsoft.AspNetCore.Cors.EnableCorsAttribute();

            
            //WebAssemblyHttpMessageHandlerOptions.DefaultCredentials = FetchCredentialsOption.Include;

            builder.RootComponents.Add<App>("app");
            // CreateHostBuilder(args).Build().Run();
            await builder.Build().RunAsync();
            
        }

        //    public static IWebAssemblyHostBuilder CreateHostBuilder(string[] args) =>
        //        BlazorWebAssemblyHost.CreateDefaultBuilder()
        //            .UseBlazorStartup<Startup>();
        //}
    }
}