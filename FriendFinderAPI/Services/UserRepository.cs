using System.Threading.Tasks;
using FriendFinderAPI.Models;
using Microsoft.EntityFrameworkCore;
using FriendFinderAPI.Context;
using System.Linq;
using System.Collections.Generic;

namespace FriendFinderAPI.Services
{
    public class UserRepository : IUserRepository
    {

        private readonly FriendFinderContext _context;

        public UserRepository(FriendFinderContext context)
        {
            context = _context;
        }
        public async Task<User> GetUser()
        {

            var query = _context.Users;
            return await query.FirstOrDefaultAsync();
        }



         //missing models and context to test. 
        public IEnumerable<User> GetAllUsers()
        {
            return _context.Users.ToList();
        }
        
        //missing models and context to test. 
        public User GetUserByID(int id)
        {
            return _context.Users.FirstOrDefault(p=> p.UserID == id);
        }

        
    }
}