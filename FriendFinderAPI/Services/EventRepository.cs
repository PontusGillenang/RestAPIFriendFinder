using FriendFinderAPI.Context;
using System.Linq;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using FriendFinderAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FriendFinderAPI.Services
{
    public class EventRepository : Repository, IEventRepository
    {
     public EventRepository(FriendFinderContext context, ILogger<EventRepository> logger) : base(context,logger){

     }

      public async Task<Event> GetEvent(int eventID)
      {
          _logger.LogInformation($"Getting Event with id: {eventID}");
          IQueryable<Event> query = _context.Events.Where(e=>e.EventID == eventID);

          return await query.FirstOrDefaultAsync();
      }  

      public async Task<Event[]> GetEvents()
      {
         _logger.LogInformation("Getting events");
         IQueryable<Event> query = _context.Events;
         return await query.ToArrayAsync();
      
      }

       public async Task<Event[]> GetEventsByHobby(int hobbyID)
       {
            _logger.LogInformation($"Getting Events for hobby with ID:{hobbyID}");
            IQueryable<Event> query = _context.Events.Where(h=>h.EventHobby.HobbyID == hobbyID);

            return await query.ToArrayAsync();
       }
       public async Task<Event[]> GetEventsByHobbyLocation(int hobbyID, int locationID)
       {
           _logger.LogInformation($"Getting Events for hobby with ID:{hobbyID} and in the location with id: {locationID}");
            IQueryable<Event> query = _context.Events.Where(h=>h.EventHobby.HobbyID == hobbyID && h.EventLocation.LocationID == locationID);

            return await query.ToArrayAsync();
       }
        public async Task<Event[]> GetEventsByLocation(int locationID)
        {
            _logger.LogInformation($"Getting Events in location with location id{locationID}");
            IQueryable<Event> query = _context.Events.Where(l=>l.EventLocation.LocationID == locationID);

            return await query.ToArrayAsync();
            
        }

    }
}