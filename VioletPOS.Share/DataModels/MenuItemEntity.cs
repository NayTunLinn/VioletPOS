
using VioletPOS.Share.DataModels;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VioletPOS.Share.DataModels
{
    [Table("tbl_MenuItem")]
    public class MenuItemEntity:BaseEntity
    {
        [Key]
        public int MenuItemID { get; set; }

        [ForeignKey("Menu")]
        public int MenuID { get; set; }

        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
