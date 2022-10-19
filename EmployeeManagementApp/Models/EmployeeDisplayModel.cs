using System.ComponentModel.DataAnnotations;

namespace EmployeeManagementApp.Models
{
    public class EmployeeDisplayModel
    {
        
        public int EmployeeID { get; set; }
        [MaxLength(100)]
        [MinLength(3)]
        [Required]
        public string FirstName { get; set; }
        [MaxLength(100)]
        [MinLength(3)]
        [Required]
        public string LastName { get; set; }
        [Required]
        [MaxLength(14)]
        [RegularExpression(@"\(\d{3}\)\s\d{3}-\d{4}", ErrorMessage = "Format should match: (XXX) XXX-XXXX")]
        public string Phone { get; set; }
        [Required]
        [MaxLength(10)]
        [MinLength(5)]
        public string Zip { get; set; }
        [Required]
        public DateTime HireDate { get; set; }
    }
}
