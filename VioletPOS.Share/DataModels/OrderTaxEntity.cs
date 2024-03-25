
using VioletPOS.Share.DataModels;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VioletPOS.Share.DataModels
{
    [Table("tbl_OrderTax")]
    public class OrderTaxEntity:BaseEntity
    {
        [Key]
        public int OrderTaxID { get; set; }

        [ForeignKey("Order")]
        public int OrderID { get; set; }

        [ForeignKey("Tax")]
        public int TaxID { get; set; }
    }
}
