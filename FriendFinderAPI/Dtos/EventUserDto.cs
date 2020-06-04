using System.ComponentModel.DataAnnotations.Schema;

namespace FriendFinderAPI.Dtos
{
    public class EventUserDto
    {
        public EventDto Event { get; set; }
        public UserDto User { get; set; }
        public bool UserIsResponsible { get; set; }
    }
}