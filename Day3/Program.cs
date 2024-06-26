using Day3.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace Day3
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");
            builder.Services.AddScoped<IServices<Product>, ProductServices>();
            builder.Services
                .AddScoped(sp => 
                new HttpClient 
                { BaseAddress = new Uri(builder.Configuration.GetValue<string>("Ip")) });

            await builder.Build().RunAsync();
        }
    }
}
