namespace FriendFinderAPI.Models
{
    public class UserModel
    {
        public int UserID { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public string Phonenumber { get; set; }
        public int Age { get; set; }
        public bool Teacher { get; set; }
        //public List<HobbyModel> Hobbies { get; set; }
        //public List<PlaceModel> FavoritePlaces { get; set; }
        //public List<MatchModel> Matches { get; set; }
    }
}