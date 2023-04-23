using Microsoft.AspNetCore.Mvc;

namespace Project.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
