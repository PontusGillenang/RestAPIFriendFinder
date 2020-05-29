using FriendFinderAPI.Context;
using FriendFinderAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Linq;
using System.Threading.Tasks;

namespace FriendFinderAPI.Services
{
    public class CityRepository : Repository, ICityRepository
    {
        public CityRepository(FriendFinderContext context, ILogger<CityRepository> logger) : base(context, logger)
        {}

        public async Task<City> GetCity(int cityId)
        {
            _logger.LogInformation($"Getting city with id: {cityId}");
            IQueryable<City> query = _context.Cities
                                                .Include(location => location.Locations)
                                                .ThenInclude(hobbyLocation => hobbyLocation.HobbyLocations)
                                                .ThenInclude(hobbies => hobbies.Hobby)
                                                .Where(city => city.CityId == cityId);

            return await query.FirstOrDefaultAsync();
        }
        
        public async Task<City[]> GetCities()
        {
            _logger.LogInformation("Getting cities");
            IQueryable<City> query = _context.Cities
                                                .Include(location => location.Locations)
                                                .ThenInclude(hobbyLocation => hobbyLocation.HobbyLocations)
                                                .ThenInclude(hobbies => hobbies.Hobby)
                                                .OrderBy(city => city.CityId);

            return await query.ToArrayAsync();
        }

        public async Task<City[]> GetCitiesByHobby(string hobbyName)
        {
            _logger.LogInformation($"Getting cities were the hobby {hobbyName} exists");
            IQueryable<City> query = _context.Cities
                                               .Include(location => location.Locations)
                                               .ThenInclude(hobbyLocation => hobbyLocation.HobbyLocations)
                                               .ThenInclude(hobbies => hobbies.Hobby)
                                               .Where(location=>location.Locations.Any(hobbyLocation=>hobbyLocation.HobbyLocations.Any(hobbies => hobbies.Hobby.HobbyName.Contains(hobbyName))));

             return await query.ToArrayAsync();
        }

        public async Task<City[]> GetCitiesWithLocation(string locationName)
        {
            _logger.LogInformation($"Getting cities with locations named: {locationName}");
            IQueryable<City> query = _context.Cities
                                               .Include(location => location.Locations)
                                               .Where(l => l.Locations.Any(l => l.LocationName.Contains(locationName)));

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