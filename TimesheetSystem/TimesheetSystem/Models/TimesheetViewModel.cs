namespace TimesheetSystem.Models
{
    public class TimesheetViewModel
    {
        public List<Person> ListOfPersons { get; set; }
        public List<Timesheet> ListOfTimesheets { get; set; }
        public string Title { get; set; }
    }
}
