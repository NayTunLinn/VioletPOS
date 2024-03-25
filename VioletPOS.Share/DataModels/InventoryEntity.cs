
using VioletPOS.Share.DataModels;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VioletPOS.Share.DataModels
{
    [Table("tbl_Inventory")]

    public class InventoryEntity:BaseEntity
    {
        [Key]
        public int ItemID { get; set; }

        [ForeignKey("Product")]
        public int ProductID { get; set; }

        public int Quantity { get; set; }
        public DateTime ExpiryDate { get; set; }
        public int RestockThreshold { get; set; }

        [ForeignKey("Supplier")]
        public int SupplierID { get; set; }
    }
}
