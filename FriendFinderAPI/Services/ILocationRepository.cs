using System.Threading.Tasks;
using FriendFinderAPI.Models;

namespace FriendFinderAPI.Services
{
    public interface ILocationRepository : IRespository
    {
         Task<Location[]> GetLocations();
         Task<Location> GetLocation(int locationId);
         Task<Location[]> GetLocationsByHobby(string hobbyName);
    }
}