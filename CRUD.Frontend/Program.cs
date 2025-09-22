using CRUD.Frontend.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace CRUD.Frontend
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");
            var url = "https://localhost:7049";

            // Registra HttpClient y el servicio IRepository
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(url) });
            builder.Services.AddScoped<IRepository, Repository>(); // �Esta es la l�nea que faltaba!

            await builder.Build().RunAsync();
        }
    }
}