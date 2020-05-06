namespace FriendFinderAPI.Models
{
    public class Hobby
    {
        enum HobbyActivationLevel 
        {
            Beginner,
            Intermediate,
            Skilled,
            Expert
        }
        public int HobbyID { get; set; }
        public string HobbyName { get; set; }
    }
}