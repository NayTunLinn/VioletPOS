
using VioletPOS.Share.DataModels;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VioletPOS.Share.DataModels
{
    [Table("tbl_ExpenseCategory")]
    public class ExpenseCategoryEntity:BaseEntity
    {
        [Key]
        public int ExpenseCategoryID { get; set; }
        public string Category { get; set; }

    }
}
