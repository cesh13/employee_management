using EmployeeManagementDataAccess.Models;

namespace EmployeeManagementDataAccess.DataAccess
{
    internal interface IEmployeeData
    {
        Task<IEnumerable<EmployeeModel>> GetAllEmployees();
    }
}