using System.Collections.Generic;

namespace FriendFinderAPI.Models
{
    public class Location
    {
        public int LocationID { get; set; }
        public string LocationName { get; set; }
        public City City { get; set; }
        public ICollection<Hobby> Hobbies { get; set; }
    }
}