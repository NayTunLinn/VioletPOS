
using VioletPOS.Share.DataModels;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VioletPOS.Share.DataModels
{
    [Table("tbl_InventoryStatus")]
    public class InventoryStatusEntity:BaseEntity
    {
        [Key]
        public int InventoryStatusID { get; set; }
        public string Status { get; set; }

    }
}
