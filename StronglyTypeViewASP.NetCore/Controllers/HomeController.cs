using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using StronglyTypeViewASP.NetCore.Models;

namespace StronglyTypeViewASP.NetCore.Controllers
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
            //Employee emp = new Employee()
            //{
            //    EmpId = 1,
            //    EmpName = "Test",
            //    Designation = ".net",
            //    salary = 16000
            //};
            var employee = new List<Employee>
           { new Employee { EmpId = 1, EmpName = "Rahul Sharma", Designation = "Software Engineer", salary = 55000 },
            new Employee { EmpId = 2, EmpName = "Anita Desai", Designation = "Team Lead", salary = 75000 },
            new Employee { EmpId = 3, EmpName = "Vikram Singh", Designation = "Project Manager", salary = 90000 },
            new Employee { EmpId = 4, EmpName = "Pooja Patel", Designation = "QA Analyst", salary = 48000 },
            new Employee { EmpId = 5, EmpName = "Amit Verma", Designation = "HR Executive", salary = 40000 },
            new Employee { EmpId = 6, EmpName = "Sneha Kapoor", Designation = "Business Analyst", salary = 62000 },
            new Employee { EmpId = 7, EmpName = "Rohit Mehra", Designation = "UI/UX Designer", salary = 53000 },
            new Employee { EmpId = 8, EmpName = "Kiran Joshi", Designation = "Backend Developer", salary = 58000 },
            new Employee { EmpId = 9, EmpName = "Deepak Yadav", Designation = "Frontend Developer", salary = 56000 },
            new Employee { EmpId = 10, EmpName = "Nikita Jain", Designation = "Scrum Master", salary = 71000 },
            new Employee { EmpId = 11, EmpName = "Suresh Rathi", Designation = "DevOps Engineer", salary = 67000 },
            new Employee { EmpId = 12, EmpName = "Tina D'Souza", Designation = "Technical Writer", salary = 45000 },
            new Employee { EmpId = 13, EmpName = "Manoj Nair", Designation = "Security Analyst", salary = 64000 },
            new Employee { EmpId = 14, EmpName = "Jyoti Kumari", Designation = "Database Admin", salary = 60000 },
            new Employee { EmpId = 15, EmpName = "Ravi Shetty", Designation = "Product Manager", salary = 88000 },
            new Employee { EmpId = 16, EmpName = "Preeti Gupta", Designation = "Support Engineer", salary = 42000 },
            new Employee { EmpId = 17, EmpName = "Ashish Rawat", Designation = "Cloud Engineer", salary = 73000 },
            new Employee { EmpId = 18, EmpName = "Bhavna Singh", Designation = "System Analyst", salary = 61000 },
            new Employee { EmpId = 19, EmpName = "Neeraj Thakur", Designation = "Mobile Developer", salary = 59000 },
            new Employee { EmpId = 20, EmpName = "Meera Iyer", Designation = "Network Engineer", salary = 57000 }


            };


            return View(employee);
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
