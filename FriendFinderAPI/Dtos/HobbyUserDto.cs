using System.ComponentModel.DataAnnotations.Schema;

namespace FriendFinderAPI.Dtos
{
    public class HobbyUserDto
    {
        [ForeignKey("HobbyID")]
        public int HobbyID { get; set; }
        public HobbyDto Hobby { get; set; }

        [ForeignKey("UserID")]
        public int UserID { get; set; }
        public UserDto User { get; set; }
    }
}