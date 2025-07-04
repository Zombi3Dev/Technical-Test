using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TimesheetSystem.Models
{
    public class Timesheet
    {
        [Key]
        public int TimesheetID { get; set; }
        public decimal MondayHours { get; set; }
        public decimal TuesdayHours { get; set; }
        public decimal WednesdayHours { get; set; }
        public decimal ThursdayHours { get; set; }
        public decimal FridayHours { get; set; }

        private decimal totalHrs;
        public Decimal TotalHours   { 
            get { return totalHrs; }
            set { totalHrs = MondayHours + TuesdayHours + WednesdayHours + ThursdayHours + FridayHours; }
        }
        public string Description { get; set; }
        //temp solution unable to create a db join 
        public int PersonID { get; set; }
        //[ForeignKey("PersonID")]
        //public required Person Person  { get; set; } 
    }
}
