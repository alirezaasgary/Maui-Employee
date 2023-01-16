using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Employee.Services;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.ViewModels
{
    public partial class EmployeesViewModel : ObservableObject
    {
        public ObservableCollection<Model.Employee> Employees { get; set; } = new ObservableCollection<Model.Employee>();
        public readonly IEmployeeService _employeeService;

        public EmployeesViewModel(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [ICommand]
        public async void GetEmployeesList()
        {
            var employeeList = await _employeeService.GetEmployeesList();
            if (employeeList?.Count > 0)
            {
                Employees.Clear();
                foreach (var employee in employeeList)
                {
                    Employees.Add(employee);
                }
            }
        }

        [ICommand]
        public async void AddUpdateEmployee()
        {
            await AppShell.Current.GoToAsync(nameof(AddEmployee));
        }
    }
}
