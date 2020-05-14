using FriendFinderAPI.Context;
using System.Linq;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using FriendFinderAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FriendFinderAPI.Services
{
    public class LocationRepository : Repository, ILocationRepository
    {
        public LocationRepository(FriendFinderContext context, ILogger<LocationRepository> logger): base(context, logger)
        {
        }

        public async Task<Location> GetLocation(int locationID)
        {
            _logger.LogInformation($"Getting Location with ID: {locationID}");
            IQueryable<Location> query = _context.Locations.Where(l=> l.LocationID == locationID);

            return await query.FirstOrDefaultAsync();

        }

        public async Task<Location> GetLocationByHobby(int locationID, int hobbyID)
        {
            _logger.LogInformation($" Getting location with id{locationID} if it includes hobby with id {hobbyID}");
            IQueryable<Location> query = _context.Locations.Where(l=>l.LocationID == locationID)
            .Include(t=>t.HobbyLocations).Where(h=>h.HobbyLocations.Any(i=>i.HobbyID == hobbyID));

            return await query.FirstOrDefaultAsync();
        }
        public async Task<Location[]> GetLocations()
        {
            _logger.LogInformation("Getting Locations");
            IQueryable<Location> query = _context.Locations;
            return await query.ToArrayAsync();
            
        }
        public async Task<Location[]> GetLocationsByHobby(int hobbyID)
        {
            _logger.LogInformation($" Getting locations for hobby with id {hobbyID}");
            IQueryable<Location> query = _context.Locations.Where(l=>l.HobbyLocations.Any(h=>h.Hobby.HobbyID == hobbyID));

            return await query.ToArrayAsync();

        }

        
        
        
    }
}