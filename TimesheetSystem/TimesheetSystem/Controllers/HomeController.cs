using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TimesheetSystem.Models;

namespace TimesheetSystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            TimesheetViewModel TimesheetVm = new TimesheetViewModel();
            TimesheetVm.ListOfPersons = new List<Person> { 
                new Person
                {
                    PersonID = 1,
                    FirstName = "Test Lewis",
                    LastName = "Archer",
                }
            };
            TimesheetVm.ListOfTimesheets = new List<Timesheet> {
                new Timesheet
                {
                    TimesheetID = 1,
                    MondayHours = 8.0m,
                    TuesdayHours = 8.5m,
                    WednesdayHours = 7.5m,
                    PersonID = 1

                },
                new Timesheet
                {
                    TimesheetID = 2,
                    MondayHours = 8.0m,
                    PersonID = 1
                }
            };
            return View(TimesheetVm);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
