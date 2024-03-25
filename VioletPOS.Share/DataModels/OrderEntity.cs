
using VioletPOS.Share.DataModels;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VioletPOS.Share.DataModels
{
    [Table("tbl_Order")]
    public class OrderEntity:BaseEntity
    {
        [Key]
        public int OrderID { get; set; }

        [ForeignKey("Customer")]
        public int CustomerID { get; set; }

        [ForeignKey("Employee")]
        public int EmployeeID { get; set; }

        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
        public string Status { get; set; }

      
    }
}
