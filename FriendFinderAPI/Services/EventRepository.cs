using FriendFinderAPI.Context;
using FriendFinderAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Linq;
using System.Threading.Tasks;

namespace FriendFinderAPI.Services
{
    public class EventRepository : Repository, IEventRepository
    {
        public EventRepository(FriendFinderContext context, ILogger<EventRepository> logger) : base(context, logger)
        {}

        public async Task<Event> GetEvent(int eventId, bool includeUsers = false)
        {
            _logger.LogInformation($"Getting event with id: {eventId}");
            IQueryable<Event> query = _context.Events
                                            .Include(hobbies => hobbies.Hobby)
                                            .Include(cities => cities.City)
                                            .ThenInclude(locations => locations.Locations)
                                            .Where(events => events.EventId == eventId);

            if (includeUsers)
            {
                _logger.LogInformation($"Getting users for the event with id: {eventId}");
                query = query.Include(eventUsers => eventUsers.EventUsers)
                             .ThenInclude(users => users.User);
            }

            return await query.FirstOrDefaultAsync();
        }

        public async Task<Event[]> GetEvents(bool includeUsers = false)
        {
            _logger.LogInformation("Getting all events");
            IQueryable<Event> query = _context.Events
                                            .Include(hobbies => hobbies.Hobby)
                                            .Include(cities => cities.City)
                                            .ThenInclude(locations => locations.Locations)
                                            .OrderBy(events => events.EventId);
                                            
            if (includeUsers)
            {
                _logger.LogInformation("Getting users for all the events");
                query = query.Include(eventUsers => eventUsers.EventUsers)
                             .ThenInclude(users => users.User);
            }

            return await query.ToArrayAsync();
        }

        public async Task<Event[]> GetEventsByHobby(string hobbyName, bool includeUsers = false)
        {
            _logger.LogInformation($"Getting events with hobby: {hobbyName}");
            IQueryable<Event> query = _context.Events
                                            .Include(hobbies => hobbies.Hobby)
                                            .Include(cities => cities.City)
                                            .ThenInclude(locations => locations.Locations)
                                            .Where(hobbies => hobbies.Hobby.HobbyName.Contains(hobbyName))
                                            .OrderBy(events => events.EventId);

            if (includeUsers)
            {
                _logger.LogInformation($"Getting the users for all events with the hobby: {hobbyName}");
                query = query.Include(eventUsers => eventUsers.EventUsers)
                             .ThenInclude(users => users.User);
            }

            return await query.ToArrayAsync();
        }
                
        public async Task<Event[]> GetEventsByCity(string cityName, bool includeUsers = false)
        {
            _logger.LogInformation($"Getting events in city: {cityName}");
            IQueryable<Event> query = _context.Events
                                            .Include(hobbies => hobbies.Hobby)
                                            .Include(cities => cities.City)
                                            .ThenInclude(locations => locations.Locations)
                                            .Where(cities => cities.City.CityName.Contains(cityName))
                                            .OrderBy(events => events.EventId);

            if (includeUsers)
            {
                _logger.LogInformation($"Getting the users for all events in the city: {cityName}");
                query = query.Include(eventUsers => eventUsers.EventUsers)
                             .ThenInclude(users => users.User);
            }

            return await query.ToArrayAsync();
        }
    }
}