using System.Threading.Tasks;
using FriendFinderAPI.Models;
using Microsoft.EntityFrameworkCore;
using FriendFinderAPI.Context;
using System.Linq;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;

namespace FriendFinderAPI.Services
{
    public class UserRepository : Repository, IUserRepository
    {
        public UserRepository(FriendFinderContext context, ILogger<UserRepository> logger) : base(context, logger)
        {
            
        }
       

        public async Task<User> GetUser(int userID)
        {
            _logger.LogInformation($"Getting user with id: {userID}");
            IQueryable<User> query = _context.Users.Where(u => u.UserID == userID);

            return await query.FirstOrDefaultAsync();
        }

        public async Task<User[]> GetAllUsers()
        {
            _logger.LogInformation("Getting Users");
            IQueryable<User> query = _context.Users;

            return await query.ToArrayAsync();
        }
    }
}