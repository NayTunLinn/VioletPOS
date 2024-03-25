namespace VioletPOS.Share.ViewModels
{


    public class OrderItemOptionViewModel
    {

        public int OrderItemOptionID { get; set; }


        public int OrderItemID { get; set; }

        public string OptionName { get; set; }
        public decimal OptionPrice { get; set; }
    }
}
