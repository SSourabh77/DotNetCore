using _LayoutImport.Models;
using Microsoft.AspNetCore.Mvc;

namespace _LayoutImport.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Student> students = new List<Student>
                {
                    new Student { Id = 1, Name = "Shubham", Gender = "Male", Class = 5 },
                    new Student { Id = 2, Name = "Anjali", Gender = "Female", Class = 6 },
                    new Student { Id = 3, Name = "Rahul", Gender = "Male", Class = 7 },
                    new Student { Id = 4, Name = "Priya", Gender = "Female", Class = 8 },
                    new Student { Id = 5, Name = "Aman", Gender = "Male", Class = 5 },
                    new Student { Id = 6, Name = "Neha", Gender = "Female", Class = 6 },
                    new Student { Id = 7, Name = "Rohit", Gender = "Male", Class = 7 },
                    new Student { Id = 8, Name = "Sneha", Gender = "Female", Class = 8 },
                    new Student { Id = 9, Name = "Kunal", Gender = "Male", Class = 5 },
                    new Student { Id = 10, Name = "Riya", Gender = "Female", Class = 6 },
                    new Student { Id = 11, Name = "Vikram", Gender = "Male", Class = 7 },
                    new Student { Id = 12, Name = "Divya", Gender = "Female", Class = 8 },
                    new Student { Id = 13, Name = "Mohit", Gender = "Male", Class = 5 },
                    new Student { Id = 14, Name = "Kriti", Gender = "Female", Class = 6 },
                    new Student { Id = 15, Name = "Yash", Gender = "Male", Class = 7 },
                    new Student { Id = 16, Name = "Isha", Gender = "Female", Class = 8 },
                    new Student { Id = 17, Name = "Arjun", Gender = "Male", Class = 5 },
                    new Student { Id = 18, Name = "Simran", Gender = "Female", Class = 6 },
                    new Student { Id = 19, Name = "Tushar", Gender = "Male", Class = 7 },
                    new Student { Id = 20, Name = "Pooja", Gender = "Female", Class = 8 }
                };



            return View(students);
        }
        public IActionResult About()
        {
            List<Student> students = new List<Student>
                {
                    new Student { Id = 1, Name = "Shubham", Gender = "Male", Class = 5 },
                    new Student { Id = 2, Name = "Anjali", Gender = "Female", Class = 6 },
                    new Student { Id = 3, Name = "Rahul", Gender = "Male", Class = 7 },
                    new Student { Id = 4, Name = "Priya", Gender = "Female", Class = 8 },
                    new Student { Id = 5, Name = "Aman", Gender = "Male", Class = 5 },
                    new Student { Id = 6, Name = "Neha", Gender = "Female", Class = 6 },
                    new Student { Id = 7, Name = "Rohit", Gender = "Male", Class = 7 },
                    new Student { Id = 8, Name = "Sneha", Gender = "Female", Class = 8 },
                    new Student { Id = 9, Name = "Kunal", Gender = "Male", Class = 5 },
                    new Student { Id = 10, Name = "Riya", Gender = "Female", Class = 6 },
                    new Student { Id = 11, Name = "Vikram", Gender = "Male", Class = 7 },
                    new Student { Id = 12, Name = "Divya", Gender = "Female", Class = 8 },
                    new Student { Id = 13, Name = "Mohit", Gender = "Male", Class = 5 },
                    new Student { Id = 14, Name = "Kriti", Gender = "Female", Class = 6 },
                    new Student { Id = 15, Name = "Yash", Gender = "Male", Class = 7 },
                    new Student { Id = 16, Name = "Isha", Gender = "Female", Class = 8 },
                    new Student { Id = 17, Name = "Arjun", Gender = "Male", Class = 5 },
                    new Student { Id = 18, Name = "Simran", Gender = "Female", Class = 6 },
                    new Student { Id = 19, Name = "Tushar", Gender = "Male", Class = 7 },
                    new Student { Id = 20, Name = "Pooja", Gender = "Female", Class = 8 }
                };
            return View(students);
        }
        public IActionResult Contact()
        {
            List<Student> students = new List<Student>
                {
                    new Student { Id = 1, Name = "Shubham", Gender = "Male", Class = 5 },
                    new Student { Id = 2, Name = "Anjali", Gender = "Female", Class = 6 },
                    new Student { Id = 3, Name = "Rahul", Gender = "Male", Class = 7 },
                    new Student { Id = 4, Name = "Priya", Gender = "Female", Class = 8 },
                    new Student { Id = 5, Name = "Aman", Gender = "Male", Class = 5 },
                    new Student { Id = 6, Name = "Neha", Gender = "Female", Class = 6 },
                    new Student { Id = 7, Name = "Rohit", Gender = "Male", Class = 7 },
                    new Student { Id = 8, Name = "Sneha", Gender = "Female", Class = 8 },
                    new Student { Id = 9, Name = "Kunal", Gender = "Male", Class = 5 },
                    new Student { Id = 10, Name = "Riya", Gender = "Female", Class = 6 },
                    new Student { Id = 11, Name = "Vikram", Gender = "Male", Class = 7 },
                    new Student { Id = 12, Name = "Divya", Gender = "Female", Class = 8 },
                    new Student { Id = 13, Name = "Mohit", Gender = "Male", Class = 5 },
                    new Student { Id = 14, Name = "Kriti", Gender = "Female", Class = 6 },
                    new Student { Id = 15, Name = "Yash", Gender = "Male", Class = 7 },
                    new Student { Id = 16, Name = "Isha", Gender = "Female", Class = 8 },
                    new Student { Id = 17, Name = "Arjun", Gender = "Male", Class = 5 },
                    new Student { Id = 18, Name = "Simran", Gender = "Female", Class = 6 },
                    new Student { Id = 19, Name = "Tushar", Gender = "Male", Class = 7 },
                    new Student { Id = 20, Name = "Pooja", Gender = "Female", Class = 8 }
                };
            return View(students);
        }
    }
}
