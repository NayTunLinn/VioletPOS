
using VioletPOS.Share.DataModels;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace VioletPOS.Share.DataModels
{
    [Table("tbl_ReservationLog")]
    public class ReservationLogEntity:BaseEntity
    {
        [Key]
        public int ReservationLogID { get; set; }

        [ForeignKey("Reservation")]
        public int ReservationID { get; set; }

        public DateTime LogDate { get; set; }
        public string LogDetails { get; set; }

    }
}
