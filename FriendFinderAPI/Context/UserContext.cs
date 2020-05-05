using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace FriendFinderAPI.Context
{
    public class UserContext : DbContext
    {
        public DbSet<User> Users {get; set};
        public UserContext(DbContextOptions<UserContext> options) : base (options)
        {

        }
        
    }
}