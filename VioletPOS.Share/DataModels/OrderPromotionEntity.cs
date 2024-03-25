using VioletPOS.Share.DataModels;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VioletPOS.Share.DataModels
{
    [Table("tbl_OrderPromotion")]
    public class OrderPromotionEntity:BaseEntity
    {
        [Key]
        public int OrderPromotionID { get; set; }

        [ForeignKey("Order")]
        public int OrderID { get; set; }

        [ForeignKey("Promotion")]
        public int PromotionID { get; set; }
    }
}
