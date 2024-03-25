using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VioletPOS.Share.DataModels
{
    [Table("tbl_Customer")]

    public class CustomerEntity : BaseEntity
    {
        [Key]
        public string CustomerID { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public decimal? LoyaltyPoints { get; set; }

    }
}
