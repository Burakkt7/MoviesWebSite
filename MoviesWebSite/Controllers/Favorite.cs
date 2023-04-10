using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MoviesWebSite.Context;
using MoviesWebSite.Models;
using System.Linq;
using System.Reflection.Metadata;

namespace MoviesWebSite.Controllers
{
    public class Favorite : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
       
        public async Task<IActionResult> Add(int? Id)
        {
            BurakDBContext Context = new BurakDBContext();
            if (Id != null)
            {
                var Movie = await Context.Movies.Where(a => a.Id == Id).FirstOrDefaultAsync();
                var favorite = new Models.Favorite()
                {
                    
                    Name = Movie.Name,
                    MovieYazar=Movie.MovieYazar,
                    MovieCatagories=Movie.MovieCatagories,
                    MovieIMDB=Movie.MovieIMDB,
                    Hakkında=Movie.Hakkında,
                    GenelDetay=Movie.GenelDetay
                };             
                await Context.Favorites.AddAsync(favorite);
                Context.SaveChanges();
                return RedirectToAction("UserFavorites");
             
            }
            if (Id == null)
            {
                return RedirectToAction("UserFavorites");
            }
            return View();
        }
        public async Task<IActionResult> UserFavorites( )
        {
            BurakDBContext Context = new BurakDBContext();
            var FavoriteSetData =await Context.Favorites.ToListAsync();
        
            return View(FavoriteSetData);
        }
   
        public async Task<IActionResult> Delete( int? Id)
        {
            BurakDBContext Context = new BurakDBContext();
            var Editdata = await Context.Favorites.FirstOrDefaultAsync(x => x.Id == Id);
            if (Id !=null)
            {
                Context.Favorites.Remove(Editdata);
                Context.SaveChanges();
                return RedirectToAction("UserFavorites");
            }    
            else if (Id ==null) {
                return RedirectToAction("UserFavorites");
            }
            return View();
        }
    }
}

