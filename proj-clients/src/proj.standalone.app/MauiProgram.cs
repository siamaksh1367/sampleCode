using Microsoft.Extensions.Logging;
using proj.components.Services.Local;
using proj.service.registrations;
using proj.standalone.app.PlatformSpecification;

namespace proj.standalone.app
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            builder.Services.AddMauiBlazorWebView();
            builder.Services.AddTransient<IPlatformService, PlatformService>();
            builder.Services.AddTransient<IStorageService, LocalStorageService>();
#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
            builder.Logging.AddDebug();
#endif
            builder.Services.RegisterServices();

            return builder.Build();
        }
    }
}