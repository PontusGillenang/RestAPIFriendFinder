using System.Threading.Tasks;
using FriendFinderAPI.Models;

namespace FriendFinderAPI.Services
{
    public interface ICityRepository : IRespository
    {
        Task<City[]> GetCities();
        Task<City> GetCity(int CityID);

        Task<City[]> GetCitiesByHobby(int hobbyID);

    }

}