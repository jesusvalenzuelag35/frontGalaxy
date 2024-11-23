using Celulares.UI;
using Celulares.UI.Proxy.Implementaciones;
using Celulares.UI.Proxy.Interfaces;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using CurrieTechnologies.Razor.SweetAlert2;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddBlazorBootstrap();
// https://localhost:7104/api/
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://tallerdecelulares.somee.com/api/") });
//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7104/api/") });
builder.Services.AddScoped<IUsuarioService, UsuarioServiceImpl>();
builder.Services.AddScoped<IFoliador, FoliadorImpl>();
builder.Services.AddScoped<IOrdenesService, OrdenesServiceImpl>();
builder.Services.AddSweetAlert2();

await builder.Build().RunAsync();
