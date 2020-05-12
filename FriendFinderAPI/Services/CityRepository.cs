using FriendFinderAPI.Context;
using System.Linq;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using FriendFinderAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FriendFinderAPI.Services
{
    public class CityRepository : Repository, ICityRepository
    {
        public CityRepository(FriendFinderContext context, ILogger<CityRepository> logger) : base(context, logger)
        {
        }
        public async Task<City> GetCity(int CityID)
        {
            _logger.LogInformation($"Getting City with id: {CityID}");
            IQueryable<City> query = _context.Cities.Where(u => u.CityID == CityID);

            return await query.FirstOrDefaultAsync();
        }
        public async Task<City[]> GetCities()
        {
            _logger.LogInformation("Getting Cities");
            IQueryable<City> query = _context.Cities;
            return await query.ToArrayAsync();
        }
    }
}