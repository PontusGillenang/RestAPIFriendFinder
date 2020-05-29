using FriendFinderAPI.Models;
using System.Threading.Tasks;

namespace FriendFinderAPI.Services
{
    public interface ICityRepository : IRespository
    {
        Task<City> GetCity(int cityId);

        Task<City[]> GetCities();

        Task<City[]> GetCitiesByHobby(string hobbyName);

        Task<City[]> GetCitiesWithLocation(string locationName);
    }
}