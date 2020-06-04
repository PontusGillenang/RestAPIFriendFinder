using System.ComponentModel.DataAnnotations.Schema;
using static FriendFinderAPI.Enums.Enums;

namespace FriendFinderAPI.Models
{
    public class HobbyUser
    {
        public int HobbyUserId { get; set; }
        public virtual Hobby Hobby { get; set; }
        public virtual User User { get; set; }
        public UserSkillLevel SkillLevel { get; set; }
    }
}