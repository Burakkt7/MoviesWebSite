using Microsoft.AspNetCore.Mvc;
using MoviesWebSite.Context;
using MoviesWebSite.Models;
using System.Diagnostics;

namespace MoviesWebSite.Controllers
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
            BurakDBContext  db = new BurakDBContext();  
            var MoviesList= db.Movies.ToList();

            return View(MoviesList);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}