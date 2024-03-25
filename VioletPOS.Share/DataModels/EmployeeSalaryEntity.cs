using VioletPOS.Share.DataModels;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VioletPOS.Share.DataModels
{
    [Table("tbl_EmployeeSalary")]
    public class EmployeeSalaryEntity : BaseEntity
    {
        [Key]
        public int EmployeeSalaryID { get; set; }

        [ForeignKey("Employee")]
        public int EmployeeID { get; set; }

        public decimal Amount { get; set; }
        public DateTime SalaryDate { get; set; }
    }
}
