using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using proj.components.Services.Local;
using proj.service.registrations;
using proj.standalone.app.PlatformSpecification;
using proj.web.app;
using proj.web.app.PlatformSpecification;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.RegisterServices();
builder.Services.AddTransient<IPlatformService, PlatformService>();
builder.Services.AddBlazoredLocalStorage();

builder.Services.AddTransient<IStorageService, LocalStorageService>();
var host = builder.Build();



await host.RunAsync();
