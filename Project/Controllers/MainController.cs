using Microsoft.AspNetCore.Mvc;

namespace Project.Controllers
{
    public class MainController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ContactUs()
        {
            return View();
        }
        public IActionResult SignIn()
		{
            return View();
		}
    }
}
