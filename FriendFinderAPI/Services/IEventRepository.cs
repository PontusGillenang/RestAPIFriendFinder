using System.Threading.Tasks;
using FriendFinderAPI.Models;

namespace FriendFinderAPI.Services
{
    public interface IEventRepository : IRespository
    {
         Task<Event> GetEvent(int EventID);

         Task<Event[]> GetEvents();

         Task<Event[]> GetEventsByHobby(int hobbyID);

         Task<Event[]> GetEventsByHobbyCity(int hobbyID, int cityID);

         Task<Event[]> GetEventsByCity(int cityID);
    }
}