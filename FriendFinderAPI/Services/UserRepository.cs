using System.Threading.Tasks;
//using FriendFinderAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace FriendFinderAPI.Services
{
    public class UserRepository : IUserRepository
    {

        private readonly UserContext _context;

        public UserRepository(UserContext _context)
        {
            _context = context;
        }
        public async Task<User> GetUser()
        {

            var query = _context.User;
            return await query.FirstorDefaultAsync();
        }



         //missing models and context to test. 
        public IEnumerable<User> GetAllUsers()
        {
            return _context.User.ToList();
        }
        
        //missing models and context to test. 
        public User GetUserByID(int id)
        {
            return _context.User.FirstorDefault(p=> p.UserID == id);
        }

        
    }
}