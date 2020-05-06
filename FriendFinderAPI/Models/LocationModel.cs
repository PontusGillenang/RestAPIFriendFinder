using System.Collections.Generic;

namespace FriendFinderAPI.Models
{
    public class Location
    {
        public int LocationID { get; set; }
        public string LocationName { get; set; }
        public CityModel City { get; set; }
        public ICollection<HobbyModel> Hobbies { get; set; }
    }
}