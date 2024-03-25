namespace VioletPOS.Share.ViewModels
{
    public class ShiftLogViewModel
    {

        public int ShiftLogID { get; set; }


        public int EmployeeScheduleID { get; set; }

        public DateTime LogDate { get; set; }
        public string LogDetails { get; set; }
    }
}
