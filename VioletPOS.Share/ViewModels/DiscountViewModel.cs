namespace VioletPOS.Share.ViewModels
{

    public class DiscountViewModel
    {

        public int DiscountID { get; set; }
        public string Code { get; set; }
        public decimal Amount { get; set; }
        public DateTime ExpiryDate { get; set; }
    }
}
