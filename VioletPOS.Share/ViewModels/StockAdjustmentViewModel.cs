namespace VioletPOS.Share.ViewModels
{
    public class StockAdjustmentViewModel
    {

        public int StockAdjustmentID { get; set; }


        public int InventoryID { get; set; }

        public DateTime AdjustmentDate { get; set; }
        public int AdjustedQuantity { get; set; }
    }
}
