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
        public DbSet<City> Cities {get; set;}
       public DbSet<Hobby> Hobbies {get; set;}
       public DbSet<Location> Locations {get; set;}
       public DbSet<Match> Matches {get; set;}
       public DbSet<Event> Events {get; set;} 

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("FriendFinderAPIConnection"));
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
            .HasData(new{
            UserID = 1,
            UserName = "Sebbe",
            UserAdress = "Drottninggatan",
            UserPhoneNumber = "+46XXXXXXX",
            UserAge = 20,
            UserIsTeacher = false
            }
            ,new{
            UserID = 2,
            UserName = "Oskar",
            UserAdress = "Kungsgatan",
            UserPhoneNumber = "+46XXXXXXX2",
            UserAge = 22,
            UserIsTeacher = false
            });

            modelBuilder.Entity<City>()
            .HasData(new{
            CityID = 1,
            CityName ="Göteborg",
            CityCountry = "Sweden",
            CityCounty = "Västra Götaland"
            }, new{
            CityID = 2,
            CityName ="Malmo",
            CityCountry = "Denmark",
            CityCounty = "Malmo"
            }, new{
            CityID = 3,
            CityName ="Stockholm",
            CityCountry = "Sweden",
            CityCounty = "Stockholm"
            });

            modelBuilder.Entity<Hobby>()
            .HasData(new{
             HobbyActivationLevel = HobbyActivationLevel.Skilled,
             HobbyID = 1,
             HobbyName = "Badminton"
            },
            new{
                HobbyActivationLevel = HobbyActivationLevel.Skilled,
                HobbyID = 2,
                HobbyName = "Tennis"
            });
            modelBuilder.Entity<Location>()
            .HasData(new{
            LocationID = 1,
            LocationName = "Fjäderborgen",

            });
        }
    }
}