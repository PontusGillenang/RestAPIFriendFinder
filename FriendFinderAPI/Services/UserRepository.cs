using System.Linq;
using FriendFinderAPI.Models;
using System.Threading.Tasks;
using FriendFinderAPI.Context;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace FriendFinderAPI.Services
{
    public class UserRepository : Repository, IUserRepository
    {
        public UserRepository(FriendFinderContext context, ILogger<UserRepository> logger) : base(context, logger)
        {
        }

        public async Task<User[]> GetUsers(bool includeHobbies = false, bool includeEvents = false)
        {
            _logger.LogInformation("Getting Users");
            IQueryable<User> query = _context.Users.Include(u => u.City);

            if (includeHobbies)
            {
                _logger.LogInformation($"Getting hobbies for all users");
                query = query.Include(user => user.HobbyUsers);
            }
            
            if (includeEvents)
            {
                _logger.LogInformation($"Getting events for all users");
                query = query.Include(user => user.EventUsers);
            }

            return await query.ToArrayAsync();
        }

        public async Task<User> GetUser(int userId, bool includeHobbies = false, bool includeEvents = false)
        {
            _logger.LogInformation($"Getting user with id: {userId}");
            IQueryable<User> query = _context.Users.Include(u => u.City).Where(user => user.UserId == userId);

            if (includeHobbies)
            {
                _logger.LogInformation($"Getting hobbies for all users");
                query = query.Include(user => user.HobbyUsers);
            }
            
            if (includeEvents)
            {
                _logger.LogInformation($"Getting events for all users");
                query = query.Include(user => user.EventUsers);
            }

            return await query.FirstOrDefaultAsync();
        }

        public async Task<User[]> GetUsersByHobby(int hobbyId)
        {
            _logger.LogInformation($"Getting Users for hobby with ID:{hobbyId}");
            IQueryable<User> query = _context.Users
                                            .Include(u => u.City)
                                            .Include(user => user.HobbyUsers)
                                            .Where(user => user.HobbyUsers.Any(hobbyUser => hobbyUser.Hobby.HobbyId == hobbyId))
                                            .OrderBy(user => user.HobbyUsers.First().SkillLevel);

            return await query.ToArrayAsync();
        }

        public async Task<User[]> GetUsersByEvent(int eventId)
        {
            _logger.LogInformation($"Getting Users for event with ID:{eventId}");
            IQueryable<User> query = _context.Users
                                            .Include(u => u.City)
                                            .Where(user => user.EventUsers.Any(eventUser => eventUser.EventId == eventId))
                                            .OrderBy(user => user.EventUsers.First().EventId);

            return await query.ToArrayAsync();
        }

        public async Task<User[]> GetUsersByCity(int cityId, bool includeHobbies = false, bool includeEvents = false)
        {
            _logger.LogInformation($"Getting Users in a city with ID:{cityId}");
            IQueryable<User> query = _context.Users.Include(u => u.City).Where(user => user.City.CityId == cityId );

            if (includeHobbies)
            {
                _logger.LogInformation($"Getting hobbies for all users");
                query = query.Include(user => user.HobbyUsers);
            }
            
            if (includeEvents)
            {
                _logger.LogInformation($"Getting events for all users");
                query = query.Include(user => user.EventUsers);
            }

            return await query.ToArrayAsync();
        }
    }
}