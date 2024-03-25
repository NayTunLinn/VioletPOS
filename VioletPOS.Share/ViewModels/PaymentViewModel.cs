namespace VioletPOS.Share.ViewModels
{

    public class PaymentViewModel
    {
        public int PaymentID { get; set; }


        public int OrderID { get; set; }

        public DateTime PaymentDate { get; set; }
        public decimal Amount { get; set; }
        public string PaymentMethod { get; set; }
    }
}
