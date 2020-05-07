namespace FriendFinderAPI.Models
{
    public class Event
    {
        public string EventName {get;set;}
        public Hobby EventHobby {get;set;}
        public User EventResposible {get;set;}
        
        public City EventCity {get;set;}
    }
}