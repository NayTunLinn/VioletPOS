
using VioletPOS.Share.DataModels;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VioletPOS.Share.DataModels
{
    [Table("tbl_ReservationStatus")]
    public class ReservationStatusEntity:BaseEntity
    {
        [Key]
        public int ReservationStatusID { get; set; }
        public string Status { get; set; }

    }
}
