namespace VioletPOS.Share.ViewModels
{

    public class ExpenseViewModel
    {

        public int ExpenseID { get; set; }
        public string Category { get; set; }
        public decimal Amount { get; set; }
        public DateTime ExpenseDate { get; set; }
    }
}
