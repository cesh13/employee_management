using EmployeeManagementDataAccess.DataConnection;
using EmployeeManagementDataAccess.Models;

namespace EmployeeManagementDataAccess.DataAccess
{
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
    }
}
