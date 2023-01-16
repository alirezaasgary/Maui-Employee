using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Employee.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.ViewModels
{
    public partial class AddEmployeeViewModel : ObservableObject
    {
        private readonly IEmployeeService _employeeService;
        public AddEmployeeViewModel(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
            EmployeeDetails = new Model.Employee();
        }

        [ObservableProperty]
        public Model.Employee employeeDetails;

        [RelayCommand]
        public async void AddEmployee()
        {
            var respons = await _employeeService.AddEmployees(employeeDetails);
            if (respons > 0)
            {
                await Shell.Current.DisplayAlert("Record Added", "Employee details successfully Submitted", "ok");
            }
            else
            {
                await Shell.Current.DisplayAlert("Not Added", "Somthing went wrong Submitted", "ok");

            }
        }
    }
}
