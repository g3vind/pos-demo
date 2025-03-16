using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using pos_demo.Data;
using pos_demo.Pages;
using pos_demo.ViewModels;

namespace pos_demo;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .UseMauiCommunityToolkit()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("Poppins-Regular.ttf", "PoppinsRegular");
                fonts.AddFont("Poppins-Bold.ttf", "PoppinsBold");
            });

#if DEBUG
        builder.Logging.AddDebug();
#endif
        builder.Services.AddSingleton<DatabaseService>();
        builder.Services.AddSingleton<HomePageViewModel>();
        builder.Services.AddSingleton<MainPage>();
        return builder.Build();
    }
}
