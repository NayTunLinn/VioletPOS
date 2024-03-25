
using VioletPOS.Share.DataModels;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VioletPOS.Share.DataModels
{
    [Table("tbl_SupplierStatus")]
    public class SupplierStatusEntity:BaseEntity
    {
        [Key]
        public int SupplierStatusID { get; set; }
        public string Status { get; set; }

    }
}
