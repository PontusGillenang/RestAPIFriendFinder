namespace FriendFinderAPI.Models
{
    public class UserPlaceModel
    {
        public int UserID { get; set; }
        public int PlaceID { get; set; }
        public string FavoritePlace { get; set; }
        public string LeastFavoritePlace { get; set; }
    }
}