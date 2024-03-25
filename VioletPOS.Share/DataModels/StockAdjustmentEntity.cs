
using VioletPOS.Share.DataModels;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VioletPOS.Share.DataModels
{
    [Table("tbl_StockAdjustment")]
    public class StockAdjustmentEntity:BaseEntity
    {
        [Key]
        public int StockAdjustmentID { get; set; }

        [ForeignKey("Inventory")]
        public int InventoryID { get; set; }

        public DateTime AdjustmentDate { get; set; }
        public int AdjustedQuantity { get; set; }
    }
}
