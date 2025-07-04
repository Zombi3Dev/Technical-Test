using System.ComponentModel.DataAnnotations;

namespace TimesheetSystem.Models
{
    public class Person
    {
        [Key]
        public int PersonID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        private string fName;
        public string FullName { 
            get { return FirstName + " " +LastName; }
        }
    }
}
