using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using FriendFinderAPI.Models;

namespace FriendFinderAPI.Context
{
    public class FriendFinderContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public FriendFinderContext(IConfiguration config , DbContextOptions options) : base (options)
        {
            _configuration = config;
        }

        public DbSet<User> Users {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("Data:FriendFinderAPIConnection:ConnectionString"));
        }
    }
}