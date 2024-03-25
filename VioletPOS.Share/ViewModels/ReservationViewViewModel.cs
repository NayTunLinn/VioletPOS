namespace VioletPOS.Share.ViewModels
{

    public class ReservationViewViewModel

    {

        public int ReservationID { get; set; }


        public int CustomerID { get; set; }


        public int TableID { get; set; }

        public DateTime ReservationDate { get; set; }
        public string Status { get; set; }

    }
}
