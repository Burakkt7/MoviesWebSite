namespace MoviesWebSite.Models
{
    public class Movie : BaseEntity
    {
        public string MovieCatagories { get; set; }
        public string MovieYazar { get; set; }
        public float MovieIMDB { get; set;}
        public string Hakkında { get; set; }
        public string GenelDetay { get; set; }

    }
}
