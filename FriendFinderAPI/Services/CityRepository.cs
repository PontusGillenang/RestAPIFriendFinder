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

        //-----------------------------------------------------------------------------
        // GetCity
        //-----------------------------------------------------------------------------							
        public async Task<City> GetCity(int cityId)
        {
            _logger.LogInformation($"Getting City with id: {cityId}");
            IQueryable<City> query = _context.Cities.Where(u => u.CityId == cityId);

            return await query.FirstOrDefaultAsync();
        }

        //-----------------------------------------------------------------------------
        // GetCities
        //-----------------------------------------------------------------------------							
        public async Task<City[]> GetCities()
        {
            _logger.LogInformation("Getting Cities");
            IQueryable<City> query = _context.Cities;
            return await query.ToArrayAsync();
        }


        //-----------------------------------------------------------------------------
        // GetCitiesByHobby
        //-----------------------------------------------------------------------------							
        public async Task<City[]> GetCitiesByHobby(int hobbyId)
        {
            _logger.LogInformation($"Getting Cities Where hobby with id {hobbyId} exists");
            IQueryable<City> query = _context.Cities.Include(location => location.Locations)
                                                    .ThenInclude(hobbyLocation => hobbyLocation.HobbyLocations)
                                                    .ThenInclude(hobby => hobby.Hobby);
                                                    //.Where(g => g. );
                                                         

             return await query.ToArrayAsync();

        }


        //-----------------------------------------------------------------------------
        // getAllLocsBelongingToCity
        //-----------------------------------------------------------------------------							
        public async Task<City[]> GetLocationsForCity(int cityId)
        {
            _logger.LogInformation($"Getting all locations part of town {cityId}");
            IQueryable<City> query = _context.Cities.Where(l => l.CityId == cityId).Include(l => l.Locations);

            // SELECT*
            // FROM[Cities] JOIN Locations
            // ON[Cities].CityID = Locations.LocationCityID
            // where[Cities].CityID = 1


            return await query.ToArrayAsync();

        }



    }
}