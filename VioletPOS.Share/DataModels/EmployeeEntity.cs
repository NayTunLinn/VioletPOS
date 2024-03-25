using VioletPOS.Share.DataModels;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VioletPOS.Share.DataModels
{
    [Table("tbl_Employee")]

    public class EmployeeEntity:BaseEntity
    {
        [Key]
        public int EmployeeID { get; set; }
        public string Code { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public DateTime DOB { get; set; }
        [Required]
        public DateTime DOE { get; set; }

        public DateTime? DOR { get; set; }
        [Required]
        public decimal BasicSalary { get; set; }
        [Required]
        public string Gender { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }
    }
}
