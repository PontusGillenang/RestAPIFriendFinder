using System.ComponentModel.DataAnnotations.Schema;

namespace FriendFinderAPI.Dtos
{
    public class EventUserDto
    {
        [ForeignKey("EventId")]
        public int EventId { get; set; }
        public EventDto Event { get; set; }
        
        [ForeignKey("UserId")]
        public int UserId { get; set; }
        public UserDto User { get; set; }
        public bool UserIsResponsible { get; set; }
    }
}