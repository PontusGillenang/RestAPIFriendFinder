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
          Event query = await _context.Events.Where(e=>e.EventID == eventID).FirstOrDefaultAsync();

          return query;
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
       public async Task<Event[]> GetEventsByHobbyCity(int hobbyID, int cityID)
       {
           _logger.LogInformation($"Getting Events for hobby with ID:{hobbyID} and in the location with id: {cityID}");
            IQueryable<Event> query = _context.Events.Where(h=>h.EventHobby.HobbyID == hobbyID && h.EventCity.CityID == cityID);

            return await query.ToArrayAsync();
       }
        public async Task<Event[]> GetEventsByCity(int cityID)
        {
            _logger.LogInformation($"Getting Events in location with location id{cityID}");
            IQueryable<Event> query = _context.Events.Where(l=>l.EventCity.CityID == cityID);

            return await query.ToArrayAsync();
            
        }

    }
}