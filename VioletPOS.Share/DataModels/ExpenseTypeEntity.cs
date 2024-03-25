
using VioletPOS.Share.DataModels;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VioletPOS.Share.DataModels
{
    [Table("tbl_ExpenseType")]
    public class ExpenseTypeEntity : BaseEntity
    {
        [Key]
        public int ExpenseTypeID { get; set; }
        public string Type { get; set; }

    }
}
