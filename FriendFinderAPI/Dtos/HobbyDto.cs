using System.Collections.Generic;

namespace FriendFinderAPI.Dtos
{
    public class HobbyDto
    {
        public int HobbyId { get; set; }
        public string HobbyName { get; set; }
        public IEnumerable<LinkDto> Links { get; set; }
    }
}