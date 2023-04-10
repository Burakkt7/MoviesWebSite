using Microsoft.AspNetCore.Mvc;

namespace MoviesWebSite.Controllers
{
    public class User : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
