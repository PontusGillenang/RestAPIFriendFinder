using System.Collections.Generic;

namespace FriendFinderAPI.Dtos
{
    public class CityDto
    {
        public int CityId { get; set; }
        public string CityName { get; set; }
        public string CityCountry { get; set; }
        public string CityCounty { get; set; }
        public ICollection<UserDto> Users { get; set; }
        public ICollection<LocationDto> Locations { get; set; }
        public IEnumerable<LinkDto> Links { get; set; }
    }
}
