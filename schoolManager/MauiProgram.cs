using Microsoft.Extensions.Logging;
using schoolManager.Services;

namespace schoolManager;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		AppServices.loadData();
		Console.WriteLine("data loaded");
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

		return builder.Build();
	}
}
