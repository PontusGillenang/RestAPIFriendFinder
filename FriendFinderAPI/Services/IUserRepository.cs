using System.Threading.Tasks;
using FriendFinderAPI.Models;

namespace FriendFinderAPI.Services
{
    public interface IUserRepository : IRespository
    {
        Task<User[]> GetAllUsers();
         Task<User> GetUser(int userID);
         
    }
}