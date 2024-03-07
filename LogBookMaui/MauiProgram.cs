using CommunityToolkit.Maui;
using Logbook.Lib;
using LogBook.LogbookCore.ViewModels;
using LogBookMaui.Pages;
using Microsoft.Extensions.Logging;

namespace LogBookMaui
{
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
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });
            builder.Services.AddSingleton<MainViewmodel>();
            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddSingleton<ReportViewModel>();
            builder.Services.AddSingleton<ReportPage>();
            string path = FileSystem.Current.AppDataDirectory;
            string filename = "data.xml";
            string fullpath = System.IO.Path.Combine(path, filename);
            System.Diagnostics.Debug.WriteLine(path);
            builder.Services.AddSingleton<IRepository>(new xmlRepository(fullpath));
#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
