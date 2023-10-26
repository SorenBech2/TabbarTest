using Microsoft.Extensions.Logging;
using TabbarTest.Auxiliaries;
using TabbarTest.View;

namespace TabbarTest
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
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            
            builder.Services.AddSingleton<AppShell>();
            builder.Services.AddSingleton<Tracker>();

            builder.Services.AddTransient<MainPage>();
            builder.Services.AddTransient<Page3>();
            builder.Services.AddTransient<Page4>();
            return builder.Build();
        }
    }
}
