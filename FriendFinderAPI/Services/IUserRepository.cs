using System.Threading.Tasks;
using FriendFinderAPI.Models;

namespace FriendFinderAPI.Services
{
    public interface IUserRepository
    {
         Task<User> GetUser();
    }
}