using System.ComponentModel.DataAnnotations.Schema;
using static FriendFinderAPI.Enums.Enums;

namespace FriendFinderAPI.Dtos
{
    public class HobbyUserDto
    {
        public HobbyDto Hobby { get; set; }
        public UserDto User { get; set; }
        public UserSkillLevel SkillLevel { get; set; }
    }
}