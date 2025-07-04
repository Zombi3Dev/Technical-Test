using TimesheetSystem.Models;

namespace TimesheetSystem.BusinessLogic
{
    public class TimesheetActions
    {
        public int CreateNewID()
        {
            return 0;
        }
        public static bool CheckPersonDuplicate(List<Person> ListOfPeople, Person PersonDetails)
        {
            Person tempPerson = (Person)ListOfPeople.Where(p => p.PersonID != PersonDetails.PersonID);
            bool isDuplicate = tempPerson.PersonID != null ? true : false;
            return isDuplicate;
        }

        public bool AddNewPerson(string firstName, string lastName, List<Person>listOfPeople) 
        {
            bool isPersonAdded = false;
            Person person = new Person();
            person.FirstName = firstName;
            person.LastName = lastName;
            if (CheckPersonDuplicate(listOfPeople, person)) {
                listOfPeople.Add(person);
                isPersonAdded = true;
            }
            else { 
                isPersonAdded |= false;
            }
            return isPersonAdded;
        }
       
        /*public Timesheet AddNewTimesheet(Person personID)
        {

            return new Timesheet();
        }*/
    }
}
