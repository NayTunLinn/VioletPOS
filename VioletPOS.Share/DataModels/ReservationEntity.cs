
using VioletPOS.Share.DataModels;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VioletPOS.Share.DataModels
{
    [Table("tbl_Reservation")]

    public class ReservationEntity:BaseEntity

    {
        [Key]
        public int ReservationID { get; set; }

        [ForeignKey("Customer")]
        public int CustomerID { get; set; }

        [ForeignKey("Table")]
        public int TableID { get; set; }

        public DateTime ReservationDate { get; set; }
        public string Status { get; set; }

    }
}
