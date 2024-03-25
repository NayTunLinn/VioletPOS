
using VioletPOS.Share.DataModels;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VioletPOS.Share.DataModels
{
    [Table("tbl_TableStatus")]
    public class TableStatusEntity:BaseEntity
    {
        [Key]
        public int TableStatusID { get; set; }
        public string Status { get; set; }

    }
}
