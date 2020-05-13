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

        public async Task<Location[]> GetLocations()
        {
            _logger.LogInformation("Getting Locations");
            IQueryable<Location> query = _context.Locations;
            return await query.ToArrayAsync();
            
        }
    }
}