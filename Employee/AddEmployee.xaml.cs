using Employee.ViewModels;

namespace Employee;

public partial class AddEmployee : ContentPage
{
    public AddEmployee(AddEmployeeViewModel viewModel)
    {
        InitializeComponent();
        this.BindingContext = viewModel;
    }
}