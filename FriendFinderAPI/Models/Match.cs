namespace FriendFinderAPI.Models
{
    public class Match
    {
        public int MatchID { get; set; }
        public User MatchedUser1 { get; set; }
        public User MatchedUser2 { get; set; }
    }
}