using Health_Tracker.ViewModel;
using Microsoft.Extensions.DependencyInjection;

namespace Health_Tracker;

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
		builder.Services.AddSingleton<Logbook>();
		builder.Services.AddSingleton<AddWeightRecordView>();
		builder.Services.AddSingleton<WeightRecordViewModel>();

		return builder.Build();
	}
}
