
using VioletPOS.Share.DataModels;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VioletPOS.Share.DataModels
{
    [Table("tbl_OrderItemOption")]

    public class OrderItemOptionEntity:BaseEntity
    {
        [Key]
        public int OrderItemOptionID { get; set; }

        [ForeignKey("OrderItem")]
        public int OrderItemID { get; set; }

        public string OptionName { get; set; }
        public decimal OptionPrice { get; set; }
    }
}
