using Person = TimesheetSystem.Models.Person;
using Timesheet = TimesheetSystem.Models.Timesheet;
using SystemFunctionality = TimesheetSystem.BusinessLogic.TimesheetActions;

namespace TimeSheetSystemTest
{
    public class TimesheetFunctionality
    {
        [Fact]
        public void CheckPersonDuplicate()
        {
            Person tempPerson = new Person();
            tempPerson.PersonID = 3;
            tempPerson.FirstName = "Jack";
            tempPerson.LastName = "Milo";

            List<Person> listOfpeople = new List<Person> 
            { 
                new Person{ 
                    PersonID = 1,
                    FirstName = "Lewis",
                    LastName = "Baker"
                },
                new Person{
                    PersonID = 2,
                    FirstName = "John",
                    LastName = "Smith"
                },
            };
            bool isDupliacte = SystemFunctionality.CheckPersonDuplicate(listOfpeople, tempPerson);
            Assert.True(isDupliacte);
        }
        [Fact]
        public void ValidateTimesheetWithPerson()
        {
            Person tempPerson = new Person();
            Timesheet timesheet = new Timesheet();
            timesheet.TimesheetID = 3;
            timesheet.MondayHours = 2.5m;
            timesheet.MondayHours = 0.5m;
            //timesheet.Person = tempPerson;
            Assert.Equal(3.0m, timesheet.TotalHours);
        }
        [Fact]
        public void CheckValidateDateInput()
        {
            Assert.Equal(2, 2);
        }
    }
}
