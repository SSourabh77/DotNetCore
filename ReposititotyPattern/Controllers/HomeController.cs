using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ReposititotyPattern.Models;
using ReposititotyPattern.Repository;

namespace ReposititotyPattern.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly StudentRepository _studentRepository = null;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _studentRepository = new StudentRepository();
        }

        public IActionResult Index()
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

        public List<StudentModel> Getallstudent()
        {
            return _studentRepository.getallStudent();
        }

        public StudentModel GetstudentByid(int id) { 
        
            return _studentRepository .getstudentbyid(id);
        }
    }
}
