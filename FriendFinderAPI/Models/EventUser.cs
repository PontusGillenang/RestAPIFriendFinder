using System.ComponentModel.DataAnnotations.Schema;

namespace FriendFinderAPI.Models
{
    public class EventUser
    {
        public int EventUserId { get; set; }
        public Event Event { get; set; }
        public virtual User User { get; set; }
        public bool UserIsResponsible { get; set; }
    }
}