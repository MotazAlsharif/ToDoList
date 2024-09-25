using Microsoft.Extensions.Logging;
using ToDoList.ViewModel;

namespace ToDoList
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
    		builder.Services.AddSingleton<MainPage>();
            builder.Services.AddSingleton<MainViewModel>();
#endif

            return builder.Build();
        }
    }
}
