using System.Collections.Generic;

namespace FriendFinderAPI.Models
{
    public class City
    {
        public int CityId { get; set; }
        public string CityName { get; set; }
        public string CityCountry { get; set; }
        public string CityCounty { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<Location> Locations { get; set; }
    }
}