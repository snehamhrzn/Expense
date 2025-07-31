using Microsoft.Extensions.Logging;
using ExpenseTracker.Services;
using MudBlazor.Services;
using Microsoft.AspNetCore.Components.WebView.Maui;

namespace ExpenseTracker;

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

#if DEBUG
        builder.Services.AddBlazorWebViewDeveloperTools();
#endif

        builder.Services.AddMauiBlazorWebView();

        // ✅ Add this line to register MudBlazor
        builder.Services.AddMudServices();

        return builder.Build();
    }
}
