namespace FriendFinderAPI.Models
{
    public class HobbyModel
    {
        /*enum ActivationLevel 
        {
            Beginner,
            Intermediate,
            Skilled,
            Expert
        }*/
        public int UserID { get; set; }
        public int HobbyID { get; set; }
        public string Name { get; set; }
    }
}