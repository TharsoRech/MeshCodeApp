using System.Security.AccessControl;
using CommunityToolkit.Maui;
using MeshCodeApp.Helpers;
using MeshCodeApp.Repository.Login;
using MeshCodeApp.ViewModels.Pages;
using MeshCodeApp.Views.Pages;

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


        builder.Services.AddSingleton<HomeMeshCodeViewModel>();
        builder.Services.AddSingleton<HomeMeshCode>();
        builder.Services.AddSingleton<LoginViewModel>();
        builder.Services.AddSingleton<Login>();
        builder.Services.AddSingleton<ProfilePageViewModel>();
        builder.Services.AddSingleton<ProfilePage>();

        builder.Services.AddScoped<ILoginRepositorio, LoginRepositorio>();

        var app = builder.Build();
        ServiceHelper.Initialize(app.Services);

        return app;
    }
}