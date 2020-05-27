using System.Threading.Tasks;
using FriendFinderAPI.Models;

namespace FriendFinderAPI.Services
{
    public interface IEventRepository : IRespository
    {
        Task<Event> GetEvent(int EventId);

        Task<Event[]> GetEvents(bool includeUsers);

        Task<Event[]> GetEventsWithHobby(string hobbyName);

        Task<Event[]> GetEventsInCity(string cityName);
    }
}