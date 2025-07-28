using Microsoft.AspNetCore.Mvc;

namespace InstallingClientSideLibrary.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
