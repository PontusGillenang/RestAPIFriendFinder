using System.ComponentModel.DataAnnotations.Schema;

namespace FriendFinderAPI.Models
{
    public class HobbyLocation
    {
        public int HobbyID { get; set; }
        public Hobby Hobby { get; set; }
        public int LocationID { get; set; }
        public Location Location { get; set; }
    }
}