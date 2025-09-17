using System.Diagnostics;
using CMCSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace CMCSystem.Controllers
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
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        // ?? New Profile action (dummy logged-in user)
        public IActionResult Profile()
        {
            ViewData["UserName"] = "Admin Operator";
            ViewData["Role"] = "Customer Service Agent";
            ViewData["Email"] = "admin@cmcsystem.co.za";
            ViewData["LastLogin"] = DateTime.Now.AddHours(-2).ToString("f"); // example: 2 hours ago

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
