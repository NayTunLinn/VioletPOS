
using VioletPOS.Share.DataModels;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VioletPOS.Share.DataModels
{
    [Table("tbl_Ingredient")]
    public class IngredientEntity:BaseEntity
    {
        [Key]
        public int IngredientID { get; set; }
        public string Name { get; set; }

    }
}
