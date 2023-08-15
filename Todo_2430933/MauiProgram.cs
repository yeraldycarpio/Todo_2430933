﻿using Microsoft.Extensions.Logging;
using Todo_2430933.Data;
using Todo_2430933.Views;

namespace Todo_2430933;

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
		builder.Logging.AddDebug();
#endif
		builder.Services.AddSingleton<TodoListPage>();
		builder.Services.AddTransient<TodoItemPage>();

		builder.Services.AddSingleton<TodoItemDatabase>();

		return builder.Build();
	}
}
