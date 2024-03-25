using VioletPOS.Share.DataModels;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VioletPOS.Share.DataModels
{
    [Table("tbl_EmployeePosition")]
    public class EmployeePositionEntity : BaseEntity
    {
        [Key]
        public int EmployeePositionID { get; set; }
        public string Position { get; set; }

    }
}
