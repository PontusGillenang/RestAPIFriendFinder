using System.Threading.Tasks;
using FriendFinderAPI.Models;

namespace FriendFinderAPI.Services
{
    public interface IUserRepository : IRespository
    {
        Task<User[]> GetUsers(bool includeHobbies, bool includeEvents);
        Task<User> GetUser(int userId, bool includeHobbies, bool includeEvents);
        Task<User[]> GetUsersByHobby(int hobbyId);
        Task<User[]> GetUsersByEvent(int eventId);
        Task<User[]> GetUsersByCity(int cityId, bool includeHobbies , bool includeEvents);
    }
}