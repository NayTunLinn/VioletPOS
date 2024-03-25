
using VioletPOS.Share.DataModels;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VioletPOS.Share.DataModels
{
    [Table("tbl_Menu")]
    public class MenuEntity:BaseEntity
    {
        [Key]
        public int MenuID { get; set; }
        public string Name { get; set; }
    }
}
