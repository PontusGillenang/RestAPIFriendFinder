using Microsoft.EntityFrameworkCore;

namespace FakeAPI.Models
{
    public class FakeContext : DbContext
    {
        public FakeContext(DbContextOptions<FakeContext> options): base(options){}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Fake>().ToTable("Fake");
            base.OnModelCreating(builder);
        }
        public DbSet<Fake> Fakes {get; set;}
    }
}