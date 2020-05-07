namespace FriendFinderAPI.Models
{
    public enum HobbyActivationLevel 
        {
            Beginner,
            Intermediate,
            Skilled,
            Expert
        }
    public class Hobby
    {
       public HobbyActivationLevel HobbyActivationLevel{get;set;}
        public int HobbyID { get; set; }
        public string HobbyName { get; set; }
    }
}