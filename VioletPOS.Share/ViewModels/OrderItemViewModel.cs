﻿namespace VioletPOS.Share.ViewModels
{


    public class OrderItemViewModel
    {
        public int OrderItemID { get; set; }


        public int OrderID { get; set; }


        public int ProductID { get; set; }

        public int Quantity { get; set; }
        public decimal Subtotal { get; set; }

    }
}
