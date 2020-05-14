using System.ComponentModel.DataAnnotations.Schema;

namespace FriendFinderAPI.Models
{
    public class HobbyUser
    {
        public int HobbyID { get; set; }
        public Hobby Hobby { get; set; }
        public int UserID { get; set; }
        public User User { get; set; }
    }
}