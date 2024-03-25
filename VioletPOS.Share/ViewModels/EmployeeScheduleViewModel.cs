namespace VioletPOS.Share.ViewModels
{

    public class EmployeeScheduleViewModel
    {

        public int EmployeeScheduleID { get; set; }


        public int EmployeeID { get; set; }

        public DateTime ShiftStart { get; set; }
        public DateTime ShiftEnd { get; set; }

    }
}
