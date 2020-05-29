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

        //-----------------------------------------------------------------------------
        // GetLocation
        //-----------------------------------------------------------------------------			
        public async Task<Location> GetLocation(int locationId /*, bool includeUsers = false*/)
        {
            _logger.LogInformation($"Getting event with id: {locationId}");
            IQueryable<Location> query = _context.Locations
                                           //.Include(hobbies => hobbies.Hobby)
                                           //.Include(cities => cities.City)
                                           //.ThenInclude(locations => locations.Locations)
                                            //.Where(events => events.EventId == locationId);
                                            .Where(l => l.LocationId == locationId);

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


        //  public async Task<Location> GetLocation(int locationId)
        //  {
        //      _logger.LogInformation($"Getting Location with ID: {locationId}");
        //      IQueryable<Location> query = _context.Locations.Where(l=> l.LocationId == locationId);
        //
        //      return await query.FirstOrDefaultAsync();
        //
        //  }


        //-----------------------------------------------------------------------------
        // GetLocationByHobby
        //-----------------------------------------------------------------------------							
        public async Task<Location[]> GetLocationsByHobby(string hobbyName)
        {
            _logger.LogInformation($"Getting events with hobby: {hobbyName}");
            IQueryable<Location> query = _context.Locations
                                            //.Include(hobbies => hobbies.Hobby)
                                            .Include(cities => cities.City)
                                            .ThenInclude(locations => locations.Locations);
                                            //.Where(hobbies => hobbies.HobbyName.Contains(hobbyName))
                                            //.OrderBy(events => events.EventId);

            return await query.ToArrayAsync();
        }
           
            
                              // public async Task<Location> GetLocationByHobby(int locationId, int hobbyId)
                         // {
                         //     _logger.LogInformation($" Getting location with id{locationId} if it includes hobby with id {hobbyId}");
                         //     IQueryable<Location> query = _context.Locations.Where(l=>l.LocationId == locationId)
                         //     .Include(t=>t.HobbyLocations).Where(h=>h.HobbyLocations.Any(i=>i.HobbyId == hobbyId));
                         //
                         //     return await query.FirstOrDefaultAsync();
                         // }







        //-----------------------------------------------------------------------------
        // GetLocations
        //-----------------------------------------------------------------------------							
        public async Task<Location[]> GetLocations()
        {
            _logger.LogInformation("Getting Locations");
            IQueryable<Location> query = _context.Locations;
            return await query.ToArrayAsync();
            
        }


        //-----------------------------------------------------------------------------
        // GetLocationsByHobby
        //-----------------------------------------------------------------------------							
        public async Task<Location[]> GetLocationsByHobby(int hobbyId)
        {
            _logger.LogInformation($" Getting locations for hobby with id {hobbyId}");
            IQueryable<Location> query = _context.Locations.Where(l=>l.HobbyLocations.Any(h=>h.Hobby.HobbyId == hobbyId));

            return await query.ToArrayAsync();

        }



        //-----------------------------------------------------------------------------
        // GetLocationsByHobby
        //-----------------------------------------------------------------------------							
        public async Task<Location> GetLocationByHobby(string eventId)
        {
            _logger.LogInformation($"Getting event with id: {eventId}");
            IQueryable<Location> query = _context.Locations
                                            //.Include(hobbies => hobbies.Hobby)
                                            .Include(cities => cities.City)
                                            .ThenInclude(locations => locations.Locations);
                                            //.Where(events => events.EventId == eventId);

           
            return await query.FirstOrDefaultAsync();
        }



    }
}