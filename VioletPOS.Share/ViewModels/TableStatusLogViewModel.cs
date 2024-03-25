namespace VioletPOS.Share.ViewModels
{

    public class TableStatusLogViewModel
    {

        public int TableStatusLogID { get; set; }


        public int TableID { get; set; }

        public DateTime LogDate { get; set; }
        public string LogDetails { get; set; } = string.Empty;
    }
}
