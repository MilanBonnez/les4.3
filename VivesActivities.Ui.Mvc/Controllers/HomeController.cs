using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using VivesActivities.Ui.Mvc.Models;
using Activity = System.Diagnostics.Activity;

namespace VivesActivities.Ui.Mvc.Controllers
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
            var activities = GetActivities();
            return View(activities);
        }

        public IActionResult About()
        {
            return View();
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

        private IList<VivesActivity> GetActivities()
        {
            return new List<VivesActivity>
            {
                new VivesActivity
                {
                    Name = "Soccer",
                    Type = "Team Sport",
                    Location = "Stadium 1",
                    Description = "Description of Soccer"
                },
                new VivesActivity
                {
                    Name = "Tennis",
                    Type = "Individual Sport",
                    Location = "Court 1",
                    Description = "Description of Tennis"
                },
                new VivesActivity
                {
                    Name = "Basketball",
                    Type = "Team Sport",
                    Location = "Arena 1",
                    Description = "Description of Basketball"
                },
                new VivesActivity
                {
                    Name = "Swimming",
                    Type = "Individual Sport",
                    Location = "Pool 1",
                    Description = "Description of Swimming"
                },
                new VivesActivity
                {
                    Name = "Volleyball",
                    Type = "Team Sport",
                    Location = "Beach 1",
                    Description = "Description of Volleyball"
                },
                new VivesActivity
                {
                    Name = "Golf",
                    Type = "Individual Sport",
                    Location = "Course 1",
                    Description = "Description of Golf"
                },
                new VivesActivity
                {
                    Name = "Badminton",
                    Type = "Individual Sport",
                    Location = "Court 2",
                    Description = "Description of Badminton"
                },
                new VivesActivity
                {
                    Name = "Hockey",
                    Type = "Team Sport",
                    Location = "Field 1",
                    Description = "Description of Hockey"
                },
                new VivesActivity
                {
                    Name = "Table Tennis",
                    Type = "Individual Sport",
                    Location = "Recreation Center 1",
                    Description = "Description of Table Tennis"
                },
                new VivesActivity
                {
                    Name = "Rugby",
                    Type = "Team Sport",
                    Location = "Field 2",
                    Description = "Description of Rugby"
                }
            };
        }
    }
}