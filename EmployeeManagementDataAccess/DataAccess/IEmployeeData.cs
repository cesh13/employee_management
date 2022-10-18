using EmployeeManagementDataAccess.Models;

namespace EmployeeManagementDataAccess.DataAccess
{
    public interface IEmployeeData
    {
        Task<IEnumerable<EmployeeModel>> GetAllEmployees();
        Task<IEnumerable<EmployeeModel>> SearchEmployees(string searchText);
        Task CreateEmployee(EmployeeModel employee);
        Task DeleteEmployee(int employeeId);
        Task<EmployeeModel> GetEmployeeById(int employeeId);
        Task UpdateEmployee(EmployeeModel employee);
    }
}