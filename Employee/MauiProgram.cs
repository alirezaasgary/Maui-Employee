using Employee.Services;
using Employee.ViewModels;
using Microsoft.Extensions.Logging;

namespace Employee;

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

		//IOC
		builder.Services.AddSingleton<IEmployeeService,EmployeeService>();

		//Views
		builder.Services.AddSingleton<EmployeesList>();
        builder.Services.AddSingleton<AddEmployee>();


        //ViewModel
        builder.Services.AddSingleton<EmployeesViewModel>();
        builder.Services.AddSingleton<AddEmployeeViewModel>();




        return builder.Build();
	}
}
