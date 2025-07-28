using System.Diagnostics;
using LoginFormUsingSessionAspCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace LoginFormUsingSessionAspCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly WaProdContext dbContext;

        public HomeController(ILogger<HomeController> logger ,WaProdContext DbContext)
        {
            _logger = logger;
            dbContext = DbContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Dashbord()
        {
            if (HttpContext.Session.GetString("User") != null)
            {
                ViewBag.UserSession = HttpContext.Session.GetString("User").ToString();
            }
            else
            {
                return RedirectToAction("Login");
            }

                return View();
        }
        [HttpPost]
        public IActionResult Login(Teacher teacher)
        {
            var myuser = dbContext.Teachers.Where(x => x.TeacherEmail == teacher.TeacherEmail && x.TeacherPass == teacher.TeacherPass).FirstOrDefault();
            if(myuser!= null)
            {
                HttpContext.Session.SetString("User", myuser.TeacherEmail);
                return RedirectToAction("Dashbord");
            }
            else
            {
                ViewBag.Message = "Login Faild";
            }
                return View(myuser);
        }


    }
}
