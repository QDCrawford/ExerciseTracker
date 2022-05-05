using ExerciseTracker.Modules.Modules;
using ExerciseTracter.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ExerciseTracter.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult User()
        {
            return View();
        }

        public IActionResult Exercise()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult User(UserViewModel user)
        {
            user.ToString();
            return View();
        }

        [HttpPost]
        public IActionResult Exercise(ExerciseViewModel exercise)
        {
            exercise.ToString();
            return View();
        }
    }
}