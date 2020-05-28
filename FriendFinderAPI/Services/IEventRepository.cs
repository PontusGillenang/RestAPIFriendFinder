using System.Threading.Tasks;
using FriendFinderAPI.Models;

namespace FriendFinderAPI.Services
{
    public interface IEventRepository : IRespository
    {
        Task<Event> GetEvent(int eventId, bool includeUsers);

        Task<Event[]> GetEvents(bool includeUsers);

        Task<Event[]> GetEventsByHobby(string hobbyName, bool includeUsers);

        Task<Event[]> GetEventsByCity(string cityName, bool includeUsers);
    }
}