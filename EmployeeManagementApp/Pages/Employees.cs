using EmployeeManagementDataAccess.DataAccess;
using Microsoft.AspNetCore.Components;
using EmployeeManagementDataAccess.Models;

namespace EmployeeManagementApp.Pages
{
    public partial class Employees
    {
        [Inject]
        public IEmployeeData _employeeData { get; set; }

        public List<EmployeeModel> employees { get; set; }

        protected override async Task OnInitializedAsync()
        {
            employees = (await _employeeData.GetAllEmployees()).ToList();

        }
    }
}
