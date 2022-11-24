using GYM_APP.ViewModel;
using GYM_APP.View;
namespace GYM_APP;

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
		builder.Services.AddTransient<LandingPage>();
		builder.Services.AddTransient<LoginPage>();
		builder.Services.AddSingleton<MainViewModel>();
        builder.Services.AddTransient<LoginViewModel>();
        builder.Services.AddSingleton<NavigationViewModel>();
	
			

		return builder.Build();
	}
}
