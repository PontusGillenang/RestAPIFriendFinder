using System.Collections.Generic;

namespace FriendFinderAPI.Models
{
    public class UserModel
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string UserAdress { get; set; }
        public string UserPhoneNumber { get; set; }
        public int UserAge { get; set; }
        public bool UserIsTeacher { get; set; }
        public ICollection<HobbyModel> Hobbies { get; set; }
        public ICollection<MatchModel> Matches { get; set; }
    }
}