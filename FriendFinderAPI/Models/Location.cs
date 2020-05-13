using System.Collections.Generic;

namespace FriendFinderAPI.Models
{
    public class Location
    {
        public int LocationID { get; set; }
        public string LocationName { get; set; }
        public City LocationCity { get; set; }
        
        public ICollection<HobbyLocation> HobbyLocations { get; set; }

    }
}