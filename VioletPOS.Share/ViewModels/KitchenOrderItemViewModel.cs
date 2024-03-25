namespace VioletPOS.Share.ViewModels
{


    public class KitchenOrderItemViewModel
    {
        public int KitchenOrderItemID { get; set; }

        public int OrderItemID { get; set; }

        public string Status { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
