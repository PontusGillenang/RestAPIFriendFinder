using System.Threading.Tasks;
using FriendFinderAPI.Models;

namespace FriendFinderAPI.Services
{
    public interface ICityRepository : IRespository
    {
        Task<City[]> GetAllCities();
        Task<City> GetCity(int CityID);

    }

}