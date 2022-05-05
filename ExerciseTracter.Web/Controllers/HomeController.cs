using ExerciseTracker.Modules.Modules;
using ExerciseTracter.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ExerciseTracter.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private static HttpClient client = new HttpClient();

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
        public async Task<IActionResult> UserAsync(UserViewModel user)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync(
                "https://localhost:7187/api/exercise/new-user", user);
            response.EnsureSuccessStatusCode();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ExerciseAsync(ExerciseViewModel exercise)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync(
                "https://localhost:7187/api/exercise/add", exercise);
            response.EnsureSuccessStatusCode();
            return View();
        }
    }
}