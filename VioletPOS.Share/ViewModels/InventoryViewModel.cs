namespace VioletPOS.Share.ViewModels
{


    public class InventoryViewModel
    {

        public int ItemID { get; set; }


        public int ProductID { get; set; }

        public int Quantity { get; set; }
        public DateTime ExpiryDate { get; set; }
        public int RestockThreshold { get; set; }


        public int SupplierID { get; set; }
    }
}
