using FriendFinderAPI.Context;
using FriendFinderAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Linq;
using System.Threading.Tasks;

namespace FriendFinderAPI.Services
{
    public class LocationRepository : Repository, ILocationRepository
    {
        public LocationRepository(FriendFinderContext context, ILogger<LocationRepository> logger): base(context, logger)
        {
        }

        //-----------------------------------------------------------------------------
        // GetLocation
        //-----------------------------------------------------------------------------			
        public async Task<Location> GetLocation(int locationId)
        {
            _logger.LogInformation($"Getting location with id: {locationId}");
            IQueryable<Location> query = _context.Locations
                                           .Include(cities => cities.City)
                                            .Include(hobbyLocations => hobbyLocations.HobbyLocations)
                                            .ThenInclude(hobbies => hobbies.Hobby)
                                            .Where(location => location.LocationId == locationId);

            #region N/A
            //if (includeUsers)
            //{
            //    _logger.LogInformation($"Getting users for the event with id: {locationId}");
            //    query = query.Include(eventUsers => eventUsers.EventUsers)
            //                 .ThenInclude(users => users.User);
            //}
            #endregion
            return await query.FirstOrDefaultAsync();
        }

        //-----------------------------------------------------------------------------
        // GetLocations
        //-----------------------------------------------------------------------------							
        public async Task<Location[]> GetLocations()
        {
            _logger.LogInformation("Getting locations");

            IQueryable<Location> query = _context.Locations
                                          .Include(cities => cities.City)
                                           .Include(hobbyLocations => hobbyLocations.HobbyLocations)
                                           .ThenInclude(hobbies => hobbies.Hobby);

            return await query.ToArrayAsync();
            
        }

        //-----------------------------------------------------------------------------
        // GetLocationByHobby
        //-----------------------------------------------------------------------------							
        public async Task<Location[]> GetLocationsByHobby(string hobbyName)
        {
            _logger.LogInformation($"Getting locations with hobby: {hobbyName}");
            IQueryable<Location> query = _context.Locations
                                            .Include(hobbyLocations => hobbyLocations.HobbyLocations)
                                            .ThenInclude(hobbies => hobbies.Hobby)
                                            .Where(hobbyLocations => hobbyLocations.HobbyLocations.Any(hobbies => hobbies.Hobby.HobbyName.Contains(hobbyName)));

            return await query.ToArrayAsync();
        }
           
    }
}