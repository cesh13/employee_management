using EmployeeManagementDataAccess.Models;

namespace EmployeeManagementDataAccess.DataAccess
{
    public interface IEmployeeData
    {
        Task<IEnumerable<EmployeeModel>> GetAllEmployees();
    }
}