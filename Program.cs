using MasaWebApp1;
using MasaWebApp1.Data;
using MasaWebApp1.Class;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");


builder.Services.AddTransient<IReadJson, ReadJsons>();
builder.Services.AddTransient<IDeserializeJson, Deserialize>();
builder.Services.AddTransient<ISerializeJson, Serializer>();
//builder.Services.AddScoped<IReader, Reader>();

builder.Services.AddMasaBlazor();
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddSingleton<WeatherForecastService>();

await builder.Build().RunAsync();
