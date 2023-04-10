using Microsoft.EntityFrameworkCore;
using MoviesWebSite.Models;

namespace MoviesWebSite.Context
{
    public class BurakDBContext:DbContext
    {
        public DbSet<Favorite> Favorites { get; set; }
        public DbSet<Movie> Movies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-V66PP0E;Database=OrnekDB ;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }
    }
}
