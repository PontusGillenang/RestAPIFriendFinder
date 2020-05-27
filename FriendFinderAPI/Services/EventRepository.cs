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

        public async Task<Event> GetEvent(int eventId)
        {
            _logger.LogInformation($"Getting event with id: {eventId}");
            IQueryable<Event> query = _context.Events
                                            .Where(events => events.EventId == eventId);

            return await query.FirstOrDefaultAsync();
        }

        public async Task<Event[]> GetEvents(bool includeUsers = false)
        {
            _logger.LogInformation("Getting all events");
            IQueryable<Event> query = _context.Events
                                            .OrderBy(events => events.EventId);
            if (includeUsers)
            {
                _logger.LogInformation("Getting all events with users included");
                query = query.Include(eventUsers => eventUsers.EventUsers)
                            .ThenInclude(users => users.User);
            }

            return await query.ToArrayAsync();
        }

        public async Task<Event[]> GetEventsWithHobby(string hobbyName)
        {
            _logger.LogInformation($"Getting events with hobby: {hobbyName}");
            IQueryable<Event> query = _context.Events
                                            .Include(eventHobby => eventHobby.Hobby)
                                            .Where(eventHobby => eventHobby.Hobby.HobbyName.Contains(hobbyName))
                                            .OrderBy(events => events.EventId);

            return await query.ToArrayAsync();
        }
                
        public async Task<Event[]> GetEventsInCity(string cityName)
        {
            _logger.LogInformation($"Getting events in city: {cityName}");
            IQueryable<Event> query = _context.Events
                                            .Include(eventCity => eventCity.City)
                                            .Where(location => location.City.CityName.Contains(cityName))
                                            .OrderBy(events => events.EventId);

            return await query.ToArrayAsync();
        }
    }
}