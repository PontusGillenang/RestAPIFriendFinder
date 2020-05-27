using System.Threading.Tasks;
using FriendFinderAPI.Models;

namespace FriendFinderAPI.Services
{
    public interface IHobbyRepository : IRespository
    {
       Task<Hobby[]> GetHobbies();
       Task<Hobby> GetHobby(int CityID);
       Task<Hobby[]> GetHobbiesByUser(int userID);
       Task<Hobby> GetHobbyByCity(int hobbyID, int cityID);
       Task<Hobby[]> GetHobbiesByCity(int cityID);
       Task<Hobby[]> GetHobbiesByLocation(int locationID);
    }
}