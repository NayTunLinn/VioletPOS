
using VioletPOS.Share.DataModels;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VioletPOS.Share.DataModels
{
    [Table("tbl_IngredientInventory")]
    public class IngredientInventoryEntity:BaseEntity
    {
        [Key]
        public int IngredientInventoryID { get; set; }

        [ForeignKey("Ingredient")]
        public int IngredientID { get; set; }

        public int Quantity { get; set; }
        public DateTime ExpiryDate { get; set; }
    }
}
