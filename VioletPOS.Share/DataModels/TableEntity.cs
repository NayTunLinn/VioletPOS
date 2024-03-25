
using VioletPOS.Share.DataModels;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VioletPOS.Share.DataModels
{
    [Table("tbl_Table")]
    public class TableEntity:BaseEntity
    {

        [Key]
        public int TableID { get; set; }
        public string TableName { get; set; }
        public int Capacity { get; set; }
        public string Status { get; set; }

    }
}
