using IgniteUI.Blazor.Controls;
using KB13150_BlazorWasmApp1;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddIgniteUIBlazor(
    typeof(IgbLegendModule),
    typeof(IgbBarSeriesModule),
    typeof(IgbDataChartCoreModule),
    typeof(IgbDataChartCategoryCoreModule),
    typeof(IgbDataChartCategoryModule),
    typeof(IgbDataChartInteractivityModule),
    typeof(IgbDataChartVerticalCategoryModule),
    typeof(IgbDataChartAnnotationModule));

await builder.Build().RunAsync();
