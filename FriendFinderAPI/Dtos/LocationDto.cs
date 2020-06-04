using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace FriendFinderAPI.Dtos
{
    public class LocationDto
    {
        public int LocationId { get; set; }
        public string LocationName { get; set; }
        public CityDto City { get; set; }
        public ICollection<HobbyLocationDto> HobbyLocations { get; set; }
        public IEnumerable<LinkDto> Links { get; set; }
    }
}