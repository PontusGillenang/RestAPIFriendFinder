using System.ComponentModel.DataAnnotations.Schema;

namespace FriendFinderAPI.Models
{
    public class HobbyLocation
    {
        public int HobbyLocationId { get; set; }
        public virtual Hobby Hobby { get; set; }
        public virtual Location Location { get; set; }
    }
}