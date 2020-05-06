namespace FriendFinderAPI.Models
{
    public class UserHobbyModel
    {
        enum UserSkillLevel 
        {
            Beginner,
            Intermediate,
            Skilled,
            Expert
        }
        public int UserID { get; set; }
        public int HobbyID { get; set; }
        //const List<HobbyModel> Hobbies;
    }
}