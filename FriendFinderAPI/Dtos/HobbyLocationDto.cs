using System.ComponentModel.DataAnnotations.Schema;

namespace FriendFinderAPI.Dtos
{
    public class HobbyLocationDto
    {
        [ForeignKey("HobbyID")]
        public int HobbyID { get; set; }
        public HobbyDto Hobby { get; set; }

        [ForeignKey("LocationID")]
        public int LocationID { get; set; }
        public LocationDto Location { get; set; }
    }
}