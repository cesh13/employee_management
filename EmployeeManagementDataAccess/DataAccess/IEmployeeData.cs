using EmployeeManagementDataAccess.Models;

namespace EmployeeManagementDataAccess.DataAccess
{
    public interface IEmployeeData
    {
        Task<IEnumerable<EmployeeModel>> GetAllEmployees();
        Task CreateEmployee(EmployeeModel employee);
        Task DeleteEmployee(int employeeId);
        Task<EmployeeModel> GetEmployeeById(int employeeId);
        public Task UpdateEmployee(EmployeeModel employee);
    }
}