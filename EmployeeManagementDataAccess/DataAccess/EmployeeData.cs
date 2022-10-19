using EmployeeManagementDataAccess.DataConnection;
using EmployeeManagementDataAccess.Models;

namespace EmployeeManagementDataAccess.DataAccess
{
    /// <summary>
    /// Implement data access functionality for employee entity
    /// </summary>
    public class EmployeeData : IEmployeeData
    {
        private readonly IDataAccess _db;

        public EmployeeData(IDataAccess db)
        {
            _db = db;
        }

        public Task<IEnumerable<EmployeeModel>> GetAllEmployees()
        {
            return _db.RetrieveMultiple<EmployeeModel, dynamic>("dbo.spEmployee_GetAll", new { });
        }

        public Task<IEnumerable<EmployeeModel>> SearchEmployees(string searchText)
        {
            return _db.RetrieveMultiple<EmployeeModel, dynamic>("dbo.spEmployee_Search", new { searchText });
        }

        public Task CreateEmployee(EmployeeModel employee)
        {
            return _db.Execute("dbo.spEmployee_Create",
                new
                {
                    employee.FirstName,
                    employee.LastName,
                    employee.Phone,
                    employee.Zip,
                    employee.HireDate
                });
        }

        public Task DeleteEmployee(int employeeId)
        {
            return _db.Execute("dbo.spEmployee_Delete",
                new
                {
                    employeeId
                });
        }

        public Task<EmployeeModel> GetEmployeeById(int employeeId)
        {
            return _db.RetrieveOne<EmployeeModel, dynamic>("dbo.spEmployee_GetOne", new { employeeId });
        }

        public Task UpdateEmployee(EmployeeModel employee)
        {
            return _db.Execute("dbo.spEmployee_Update", new
            {
                employee.EmployeeID,
                employee.FirstName,
                employee.LastName,
                employee.Phone,
                employee.Zip,
                employee.HireDate
            });
        }
    }
}
