
using VioletPOS.Share.DataModels;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VioletPOS.Share.DataModels
{
    [Table("tbl_Tax")]
    public class TaxEntity:BaseEntity
    {
        [Key]
        public int TaxID { get; set; }
        public string Name { get; set; }
        public decimal Rate { get; set; }

    }
}
