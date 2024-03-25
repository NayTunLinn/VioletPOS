namespace VioletPOS.Share.ViewModels
{

    public class IngredientInventoryViewModel
    {

        public int IngredientInventoryID { get; set; }


        public int IngredientID { get; set; }

        public int Quantity { get; set; }
        public DateTime ExpiryDate { get; set; }
    }
}
