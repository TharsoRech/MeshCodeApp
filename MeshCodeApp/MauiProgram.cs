using System.Security.AccessControl;
using CommunityToolkit.Maui;
using MeshCodeApp.Repository.Login;

namespace MeshCodeApp;
public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder.UseMauiApp<App>().ConfigureFonts(fonts =>
        {
            fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
        }).UseMauiCommunityToolkit();


        builder.Services.AddSingleton<MainViewModel>();
        builder.Services.AddSingleton<MainPage>();
        builder.Services.AddSingleton<HomeMeshCodeViewModel>();
        builder.Services.AddSingleton<HomeMeshCode>();
        builder.Services.AddSingleton<LoginViewModel>();
        builder.Services.AddSingleton<Login>();

        builder.Services.AddScoped<ILoginRepositorio, LoginRepositorio>();


        return builder.Build();
    }
}