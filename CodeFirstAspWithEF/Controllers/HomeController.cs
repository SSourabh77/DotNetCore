using System.Diagnostics;
using CodeFirstAspWithEF.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstAspWithEF.Controllers
{
    public class HomeController : Controller
    {
        private readonly StudentDbContext studentDB;

        public HomeController(StudentDbContext StudentDB)
        {
            studentDB = StudentDB;
        }

        public async Task<IActionResult> Index()
        {
            var stddata = await studentDB.Students.ToListAsync();
            return View(stddata);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Student std)
        {
            if (ModelState.IsValid)
            {
                await studentDB.Students.AddAsync(std);
                await  studentDB.SaveChangesAsync();
                TempData["CreateStudent"] = "Student Created Successfully";
                return RedirectToAction("Index");
            }

            return View(std);
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || studentDB.Students == null)
            {
                return NotFound();
            }
            var stddata = await studentDB.Students.FindAsync(id);
            if (stddata == null)
            {
                return NotFound();
            }
            return View(stddata);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id , Student std)
        {

            if(id == std.Id)
            {
                if (ModelState.IsValid)
                {
                    studentDB.Update(std);
                    await studentDB.SaveChangesAsync();
                    TempData["Update_Success"] = "Student Updated Successfully";

                    return RedirectToAction("Index", "Home");
                }
            }
            
            return View(std);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public async Task<IActionResult> Details(int? id)
        {
            if(id == null || studentDB.Students == null)
            {
                return NotFound();
            }
            var stddata = await studentDB.Students.FirstOrDefaultAsync(x => x.Id == id);
            if (stddata == null)
            {
                return NotFound();
            }
            return View(stddata);
        }


        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || studentDB.Students == null)
            {
                return NotFound();
            }
            var stddata = await studentDB.Students.FirstOrDefaultAsync(x => x.Id == id);
            if (stddata == null)
            {
                return NotFound();
            }

            return View(stddata);
        }
        [HttpPost ,ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            var stddata = await studentDB.Students.FindAsync(id);
            if(stddata!= null)
            {
                studentDB.Students.Remove(stddata);
                await studentDB.SaveChangesAsync();
                TempData["Delete_Success"] = "Student Deleted Successfully";
                return RedirectToAction("Index");
            }

            return View(stddata);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
