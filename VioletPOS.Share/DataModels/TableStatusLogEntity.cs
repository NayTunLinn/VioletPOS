
using VioletPOS.Share.DataModels;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VioletPOS.Share.DataModels
{
    [Table("tbl_TableStatusLog")]
    public class TableStatusLogEntity:BaseEntity
    {
        [Key]
        public int TableStatusLogID { get; set; }

        [ForeignKey("Table")]
        public int TableID { get; set; }

        public DateTime LogDate { get; set; }
        public string LogDetails { get; set; } = string.Empty;
    }
}
