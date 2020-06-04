using System.ComponentModel.DataAnnotations.Schema;

namespace FriendFinderAPI.Dtos
{
    public class HobbyLocationDto
    {
        public HobbyDto Hobby { get; set; }
        public LocationDto Location { get; set; }
    }
}