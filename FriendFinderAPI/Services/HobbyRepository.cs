using FriendFinderAPI.Context;
using System.Linq;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using FriendFinderAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FriendFinderAPI.Services
{
    public class HobbyRepository : Repository, IHobbyRepository
    {
        public HobbyRepository(FriendFinderContext context, ILogger<HobbyRepository> logger) : base(context, logger)
        {
        }
        public async Task<Hobby> GetHobby(int HobbyID)
        {
            _logger.LogInformation($"Getting Hobby with id: {HobbyID}");
            IQueryable<Hobby> query = _context.Hobbies.Where(u => u.HobbyID == HobbyID);

            return await query.FirstOrDefaultAsync();
        }
       public async Task<Hobby[]> GetHobbies()
        {
            _logger.LogInformation("Getting Hobbies");
            IQueryable<Hobby> query = _context.Hobbies;
            return await query.ToArrayAsync();
        }

        public async Task<Hobby> GetHobbyByCity(int hobbyID, int cityID)
        {
             _logger.LogInformation($"Getting Hobby in city with id {cityID}");
             IQueryable<Hobby> query = _context.Hobbies.Where(h=>h.HobbyLocations.Any(l=>l.Location.LocationCity.CityID == cityID) && h.HobbyID ==hobbyID);

             return await query.FirstOrDefaultAsync();
        }

        public async Task<Hobby[]> GetHobbiesByCity(int cityID)
        {
            _logger.LogInformation($"Getting Hobbies in city with id{cityID}");
            IQueryable<Hobby> query = _context.Hobbies.Where(h=>h.HobbyLocations.Any(l=>l.Location.LocationCity.CityID == cityID));

            return await query.ToArrayAsync();
        }

        public async Task<Hobby[]> GetHobbiesByUser(int userID)
        {
            _logger.LogInformation($"Getting Hobbies in city with id{userID}");
            IQueryable<Hobby> query = _context.Hobbies.Where(h=>h.HobbyUsers.Any(u=>u.UserID == userID));

            return await query.ToArrayAsync();

        }
        
    }
}