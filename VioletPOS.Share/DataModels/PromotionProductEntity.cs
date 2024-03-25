
using VioletPOS.Share.DataModels;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VioletPOS.Share.DataModels
{
    [Table("tbl_PromotionProduct")]
    public class PromotionProductEntity:BaseEntity
    {
        [Key]
        public int PromotionProductID { get; set; }

        [ForeignKey("Promotion")]
        public int PromotionID { get; set; }

        [ForeignKey("Product")]
        public int ProductID { get; set; }
    }
}
