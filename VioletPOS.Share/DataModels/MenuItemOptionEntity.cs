
using VioletPOS.Share.DataModels;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace VioletPOS.Share.DataModels
{
    [Table("tbl_MenuItemOption")]
    public class MenuItemOptionEntity : BaseEntity
    {
        [Key]
        public int MenuItemOptionID { get; set; }

        [ForeignKey("MenuItem")]
        public int MenuItemID { get; set; }

        public string OptionName { get; set; }
        public decimal OptionPrice { get; set; }

    }
}
