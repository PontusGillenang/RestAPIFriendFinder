using System.Threading.Tasks;
namespace FriendFinderAPI.Services
{
    public interface IUserRepository
    {
         Task<User> GetUser();
    }
}