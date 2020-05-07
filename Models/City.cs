using System.Data.Entity;

namespace Top15Cities.Models
{
    public class City
    {
        public int CityId { get; set; }
        public string CityName { get; set; }
        public string CityCountry { get; set; }
        public string CityInformation { get; set; }
        public string PathPhoto { get; set; }
    }

    //represents the Entity Framework
    public class Top15 : DbContext
    {
        public DbSet<City> Cities { get; set; }
    }
}