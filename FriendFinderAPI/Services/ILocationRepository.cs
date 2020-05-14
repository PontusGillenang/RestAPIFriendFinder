using System.Threading.Tasks;
using FriendFinderAPI.Models;

namespace FriendFinderAPI.Services
{
    public interface ILocationRepository : IRespository
    {
         Task<Location[]> GetLocations();

         Task<Location> GetLocation(int locationID);

         Task<Location[]> GetLocationsByHobby(int hobbyID);
        
        Task<Location> GetLocationByHobby(int locationID, int hobbyID);
        
    }
}