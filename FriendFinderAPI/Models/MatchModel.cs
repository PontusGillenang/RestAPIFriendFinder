namespace FriendFinderAPI.Models
{
    public class MatchModel
    {
        public int MatchID { get; set; }
        public UserModel MatchedUser1 { get; set; }
        public UserModel MatchedUser2 { get; set; }
    }
}