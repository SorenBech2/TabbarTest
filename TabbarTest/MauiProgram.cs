using Microsoft.Extensions.Logging;
using TabbarTest.Auxiliaries;
using TabbarTest.View;
using TabbarTest.ViewModel;

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
            // Adding services
            builder.Services.AddSingleton<AppShell>()
                            .AddSingleton<Tracker>();

            // Adding pages
            builder.Services.AddTransient<MainPage>()
                            .AddTransient<Page3>()
                            .AddTransient<Page4>()
                            .AddTransient<BorderTestPage>();
            
            // Adding view models
            builder.Services.AddTransient<BorderTestPageViewModel>();


            return builder.Build();
        }
    }
}
