using System.ComponentModel.DataAnnotations.Schema;

namespace FriendFinderAPI.Models
{
    public class EventUser
    {
        public int EventUserID { get; set; }
        [ForeignKey("EventID")]
        public int EventID { get; set; }
        public Event Event { get; set; }
        [ForeignKey("UserID")]
        public int UserID { get; set; }
        public User User { get; set; }
        public bool UserIsResponsible { get; set; }
    }
}