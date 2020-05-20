using System.ComponentModel.DataAnnotations.Schema;

namespace FriendFinderAPI.Dtos
{
    public class EventUserDto
    {
        public int EventUserID { get; set; }
        [ForeignKey("EventID")]
        public int EventID { get; set; }
        public EventDto Event { get; set; }
        [ForeignKey("UserID")]
        public int UserID { get; set; }
        public UserDto User { get; set; }
        public bool UserIsResponsible { get; set; }
    }
}