using VioletPOS.Share.DataModels;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VioletPOS.Share.DataModels
{
    [Table("tbl_DiscountProduct")]
    public class DiscountProductEntity:BaseEntity
    {
        [Key]
        public int DiscountProductID { get; set; }

        [ForeignKey("Discount")]
        public int DiscountID { get; set; }

        [ForeignKey("Product")]
        public int ProductID { get; set; }
    }
}
