namespace Employee;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(AddEmployee),typeof(AddEmployee));
	}
}
