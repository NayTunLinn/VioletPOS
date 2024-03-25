using VioletPOS.Share.DataModels;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VioletPOS.Share.DataModels
{
    [Table("tbl_Discount")]
    public class DiscountEntity:BaseEntity
    {
        [Key]
        public int DiscountID { get; set; }
        public string Code { get; set; }
        public decimal Amount { get; set; }
        public DateTime ExpiryDate { get; set; }
    }
}
