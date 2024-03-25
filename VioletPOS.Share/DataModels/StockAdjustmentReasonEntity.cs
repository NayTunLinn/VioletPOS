
using VioletPOS.Share.DataModels;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VioletPOS.Share.DataModels
{
    [Table("tbl_StockAdjustmentReason")]
    public class StockAdjustmentReasonEntity:BaseEntity
    {
        [Key]
        public int StockAdjustmentReasonID { get; set; }
        public string Reason { get; set; }
    }
}
