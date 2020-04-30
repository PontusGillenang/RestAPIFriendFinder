using Microsoft.EntityFrameworkCore;

namespace FakeAPI.Models
{
    public class FakeContext : DbContext
    {
        public DbSet<Fake> Fakes {get; set;}

        protected override void OnConfiguring(DbContextOptionBuilder optionBuilder){
            IConfiguration config = new ConfigurationBuilder().AddJsonFile("config.json", true).Build();
            optionBuilder.UseSqlServer(config["ConnectionStrings:DefaultConnection"]);
        }
    }
}