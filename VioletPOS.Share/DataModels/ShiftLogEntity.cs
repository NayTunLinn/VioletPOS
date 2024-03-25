
using VioletPOS.Share.DataModels;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VioletPOS.Share.DataModels
{
    [Table("tbl_ShiftLog")]
    public class ShiftLogEntity:BaseEntity
    {
        [Key]
        public int ShiftLogID { get; set; }

        [ForeignKey("EmployeeSchedule")]
        public int EmployeeScheduleID { get; set; }

        public DateTime LogDate { get; set; }
        public string LogDetails { get; set; }
    }
}
