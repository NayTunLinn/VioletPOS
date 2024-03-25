
using VioletPOS.Share.DataModels;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VioletPOS.Share.DataModels
{
    [Table("tbl_ShiftType")]
    public class ShiftTypeEntity : BaseEntity
    {
        [Key]
        public int ShiftTypeID { get; set; }
        public string Type { get; set; }

    }
}
