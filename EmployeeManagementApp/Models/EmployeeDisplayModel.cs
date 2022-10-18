using System.ComponentModel.DataAnnotations;

namespace EmployeeManagementApp.Models
{
    public class EmployeeDisplayModel
    {
        public int EmployeeID { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        [RegularExpression(@"\(?\d{3}\)?-? *\d{3}-? *-?\d{4}", ErrorMessage = "Format should match: (XXX) XXX-XXXX")]
        public string Phone { get; set; }
        [Required]
        public string Zip { get; set; }
        [Required]
        public DateTime HireDate { get; set; }
    }
}
