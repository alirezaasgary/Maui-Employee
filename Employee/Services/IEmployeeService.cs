using Employee.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Services
{
    public interface IEmployeeService
    {

        Task<List<Model.Employee>> GetEmployeesList();
        Task<int> AddEmployees(Model.Employee employee);
        Task<int> UpdateeEmployees(Model.Employee employee);
        Task<int> DeleteEmployees(Model.Employee employee);

    }

}
