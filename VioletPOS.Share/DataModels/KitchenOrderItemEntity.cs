
using VioletPOS.Share.DataModels;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VioletPOS.Share.DataModels
{
    [Table("tbl_KitchenOrderItem")]

    public class KitchenOrderItemEntity:BaseEntity
    {
        [Key]
        public int KitchenOrderItemID { get; set; }

        [ForeignKey("OrderItem")]
        public int OrderItemID { get; set; }

        public string Status { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
