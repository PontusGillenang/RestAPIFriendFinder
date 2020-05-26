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

        public async Task<Event[]> GetEvents()
        {
            _logger.LogInformation("Getting events");
            IQueryable<Event> query = _context.Events
                                            .Include(eventUsers => eventUsers.EventUsers)
                                            .ThenInclude(users => users.User)
                                            .ThenInclude(hobbyUsers => hobbyUsers.HobbyUsers)
                                            .ThenInclude(hobbies => hobbies.Hobby)
                                            .ThenInclude(hobbyLocation => hobbyLocation.HobbyLocations)
                                            .ThenInclude(location => location.Location)
                                            .OrderBy(events => events.EventID);
                                                   
            return await query.ToArrayAsync();
        }

        public async Task<Event> GetEvent(int eventID)
        {
            _logger.LogInformation($"Getting Event with id: {eventID}");
            IQueryable<Event> query = _context.Events
                                            .Where(events => events.EventID == eventID)
                                            .OrderBy(events => events.EventID);

            return await query.FirstOrDefaultAsync();
        }

        public async Task<Event[]> GetEventsByHobby(int hobbyID)
        {
            _logger.LogInformation($"Getting Events for hobby with ID:{hobbyID}");
            IQueryable<Event> query = _context.Events
                                            .Include(eventHobby => eventHobby.EventHobby)
                                            .Where(eventHobby => eventHobby.EventHobby.HobbyID == hobbyID)
                                            .OrderBy(hobby => hobby.EventHobbyID);

            return await query.ToArrayAsync();
        }

        public async Task<Event[]> GetEventsByHobbyCity(int hobbyID, int cityID)
        {
            _logger.LogInformation($"Getting Events for hobby with ID:{hobbyID} and in the location with id: {cityID}");
            IQueryable<Event> query = _context.Events.Where(h => h.EventHobby.HobbyID == hobbyID && h.EventCity.CityID == cityID);

            return await query.ToArrayAsync();
        }

        public async Task<Event[]> GetEventsByCity(int cityID)
        {
            _logger.LogInformation($"Getting Events in location with location id{cityID}");
            IQueryable<Event> query = _context.Events.Where(l => l.EventCity.CityID == cityID);

            return await query.ToArrayAsync();
        }
    }
}