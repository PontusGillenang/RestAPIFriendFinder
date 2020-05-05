using System.Threading.Tasks;
//using FriendFinderAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FriendFinderAPI.Services
{
    public class UserRepository
    {

        private readonly UserContext _context;
        public async Task<User> GetUser()
        {

            var query = _context.User;
            return await query.FirstorDefaultAsync();
        }
    }
}