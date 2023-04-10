using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Query.Internal;
using MoviesWebSite.Context;
using MoviesWebSite.Models;
using System.Linq;

namespace MoviesWebSite.Controllers
{
    public class Movies : Controller
    {
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Movie movie , string? MovieCatagories)
        {
            BurakDBContext dbContext = new BurakDBContext();
            if (movie!=null)
            {
                //string moviedengelenkatagori = movie.MovieCatagories;       
                await dbContext.Movies.AddAsync(movie);
                await dbContext.SaveChangesAsync();
            }
            else if (movie==null)
            {
                return RedirectToAction("Create");
            }
            return RedirectToAction(MovieCatagories);
        }
        public IActionResult Aksiyon()
        {
            BurakDBContext Context = new ();
            var gidendata =  Context.Movies.Where(x=>x.MovieCatagories==("Aksiyon")).ToList();
            return View(gidendata);           
        }
        public IActionResult Komedi()
        {
            BurakDBContext Context = new();
            var gidendata = Context.Movies.Where(x => x.MovieCatagories == ("Komedi")).ToList();

            return View(gidendata);

        }
        public IActionResult Gerilim()
        {
            BurakDBContext Context = new();
            var gidendata = Context.Movies.Where(x => x.MovieCatagories == ("Gerilim")).ToList();

            return View(gidendata);

        }
        public IActionResult Korku()
        {
            BurakDBContext Context = new();
            var gidendata = Context.Movies.Where(x => x.MovieCatagories == ("Korku")).ToList();

            return View(gidendata);
        }
        public IActionResult Detaylar(int? Id)
        {
            BurakDBContext Context = new ();
            var Editdata = Context.Movies.FirstOrDefault(x => x.Id == Id);
            if (Editdata == null)
            {
                return View("Index");
            }
            var viewmodel = new Movie()
            {
                Id = Editdata.Id,
                Name = Editdata.Name,
                MovieCatagories = Editdata.MovieCatagories,
                MovieIMDB = Editdata.MovieIMDB,
                MovieYazar = Editdata.MovieYazar,
                Hakkında = Editdata.Hakkında,
                GenelDetay = Editdata.GenelDetay
            };
            return View(viewmodel);
        }
    
    }
}
