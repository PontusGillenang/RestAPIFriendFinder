using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace FakeAPI.Models
{
    public class FakeContext : DbContext
    {
        public FakeContext(DbContextOptions<FakeContext> options) : base(options)
        {
            
        }
        public DbSet<Fake> Fakes {get; set;}

        // protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder){
        //     IConfiguration config = new ConfigurationBuilder().AddJsonFile("appsettings.json", true).Build();
        //     optionBuilder.UseSqlServer(config["ConnectionStrings:DefaultConnection"]);
        // }
    }
}