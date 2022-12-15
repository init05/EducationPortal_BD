using EducationPortalBlazorApp;
using EducationPortalBlazorApp.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

public class Program
{
    public static async Task Main(string[] args)
    {
        var builder = WebAssemblyHostBuilder.CreateDefault(args);
        builder.RootComponents.Add<App>("#app");
        builder.RootComponents.Add<HeadOutlet>("head::after");

        builder.Services.AddScoped(sp => new HttpClient {BaseAddress = new Uri("https://localhost:7017")});
        builder.Services.AddScoped<UserApiClient>();
        
        await builder.Build().RunAsync();
    }
}