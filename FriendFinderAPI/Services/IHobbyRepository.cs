using System.Threading.Tasks;
using FriendFinderAPI.Models;

namespace FriendFinderAPI.Services
{
    public interface IHobbyRepository : IRespository
    {
        Task<Hobby[]> GetHobbies();
        Task<Hobby> GetHobby(int CityID);

        Task<Hobby> GetTeachersByHobby(string hobbyName);
    }
}