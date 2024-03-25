
using VioletPOS.Share.DataModels;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VioletPOS.Share.DataModels
{
    [Table("tbl_KitchenOrder")]

    public class KitchenOrderEntity:BaseEntity
    {
        [Key]
        public int KitchenOrderID { get; set; }

        [ForeignKey("Order")]
        public int OrderID { get; set; }

        public DateTime Timestamp { get; set; }
    }
}
