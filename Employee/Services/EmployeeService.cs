using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Services
{
    public class EmployeeService : IEmployeeService
    {
        public SQLiteAsyncConnection _dbConnection;
        public EmployeeService()
        {
            SetapDatabase();
        }

        private async Task SetapDatabase()
        {
            if (_dbConnection == null)
            {

                    string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Employee.db3");
                    _dbConnection = new SQLiteAsyncConnection(path);
                    await _dbConnection.CreateTableAsync<Model.Employee>();
           
            }
        }
        public async Task<int> AddEmployees(Model.Employee employee)
        {
            return await _dbConnection.InsertAsync(employee);
        }

        public async Task<int> DeleteEmployees(Model.Employee employee)
        {
            await SetapDatabase();
            return await _dbConnection.DeleteAsync(employee);

        }

        public async Task<List<Model.Employee>> GetEmployeesList()
        {
            await SetapDatabase();
            var employeeList = await _dbConnection.Table<Model.Employee>().ToListAsync();
            return employeeList;
        }

        public async Task<int> UpdateeEmployees(Model.Employee employee)
        {
            await SetapDatabase();
            return await _dbConnection.UpdateAsync(employee);

        }
    }
}
