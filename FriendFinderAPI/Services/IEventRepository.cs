using System.Threading.Tasks;
using FriendFinderAPI.Models;

namespace FriendFinderAPI.Services
{
    public interface IEventRepository : IRespository
    {
         Task<Event> GetEvent(int EventID);

         Task<Event[]> GetEvents();

         Task<Event[]> GetEventsByHobby(int hobbyID);

         Task<Event[]> GetEventsByHobbyLocation(int hobbyID, int locationID);

         Task<Event[]> GetEventsByLocation(int locationID);
    }
}