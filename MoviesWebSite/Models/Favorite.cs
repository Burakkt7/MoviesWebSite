using MoviesWebSite.Controllers;

namespace MoviesWebSite.Models
{
    public class Favorite : BaseEntity
    {
        public string MovieCatagories { get; set; }
        public string MovieYazar { get; set; }
        public float MovieIMDB { get; set; }
        public string Hakkında { get; set; }
        public string GenelDetay { get; set; }


    }


}
