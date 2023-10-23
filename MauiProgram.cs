using guardianEyeMAUI.Services;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Logging;
using System.Security.Cryptography.X509Certificates;

namespace guardianEyeMAUI
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
            builder.Services.AddSingleton<IDetectionServices, DetectionServices>();
            builder.Services.AddSingleton<API_Main>();
#if DEBUG
        builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}