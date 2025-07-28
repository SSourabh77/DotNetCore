using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SessionASPCore9.Models;
using Microsoft.AspNetCore.Http;

namespace SessionASPCore9.Controllers
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
            HttpContext.Session.SetString("Data", "Shubham Sourabh");
            return View();
        }

        public IActionResult Privacy()
        {
           ViewBag.Data =  HttpContext.Session.GetString("Data").ToString();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
