
using VioletPOS.Share.DataModels;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace VioletPOS.Share.DataModels
{
    [Table("tbl_EmployeeSchedule")]
    public class EmployeeScheduleEntity:BaseEntity
    {
        [Key]
        public int EmployeeScheduleID { get; set; }

        [ForeignKey("Employee")]
        public int EmployeeID { get; set; }

        public DateTime ShiftStart { get; set; }
        public DateTime ShiftEnd { get; set; }

    }
}
