using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using FriendFinderAPI.Models;

namespace FriendFinderAPI.Context
{
    public class FriendFinderContext : DbContext
    {
        private readonly IConfiguration _configuration;
        public FriendFinderContext() { }
        public FriendFinderContext(IConfiguration config, DbContextOptions options) : base(options)
        {
            _configuration = config;
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Hobby> Hobbies { get; set; }
        public virtual DbSet<HobbyLocation> HobbyLocations { get; set; }
        public virtual DbSet<HobbyUser> HobbyUsers { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<Event> Events { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("FriendFinderAPIConnection"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HobbyUser>()
            .HasKey(hu => new { hu.HobbyID, hu.UserID });

            modelBuilder.Entity<HobbyUser>()
            .HasOne(hu => hu.Hobby)
            .WithMany(h => h.HobbyUsers)
            .HasForeignKey(hu => hu.HobbyID);

            modelBuilder.Entity<HobbyUser>()
            .HasOne(hu => hu.User)
            .WithMany(h => h.HobbyUsers)
            .HasForeignKey(hu => hu.UserID);

            modelBuilder.Entity<HobbyLocation>()
            .HasKey(hl => new { hl.HobbyID, hl.LocationID });

            modelBuilder.Entity<HobbyLocation>()
            .HasOne(hl => hl.Hobby)
            .WithMany(h => h.HobbyLocations)
            .HasForeignKey(hl => hl.HobbyID);

            modelBuilder.Entity<HobbyLocation>()
            .HasOne(hl => hl.Location)
            .WithMany(h => h.HobbyLocations)
            .HasForeignKey(hl => hl.LocationID);

            modelBuilder.Entity<City>()
            .HasMany<User>(c=> c.CityUsers)
            .WithOne(u=>u.UserCity)
            .HasForeignKey(u=> u.UserCityID)
            .OnDelete(DeleteBehavior.ClientSetNull);

            // modelBuilder.Entity<City>()
            // .HasMany<User>(u=> u.CityUsers)
            // .WithOne(c=> c.UserCity)
            // .OnDelete(DeleteBehavior.NoAction);

            // modelBuilder.Entity<User>()
            // .HasOne(u=> u.UserCity)
            // .WithMany(c=> c.CityUsers)
            // .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<User>()
            .HasData(new
            {
                UserID = 1,
                UserName = "Sebbe",
                UserAdress = "Drottninggatan",
                UserPhoneNumber = "+46XXXXXXX",
                UserAge = 20,
                UserIsTeacher = true,
                UserCityID = 18153,
            }
            , new
            {
                UserID = 2,
                UserName = "Oskar",
                UserAdress = "Kungsgatan",
                UserPhoneNumber = "+46XXXXXXX2",
                UserAge = 22,
                UserIsTeacher = false,
                UserCityID = 18153,
            }
            , new
            {
                UserID = 3,
                UserName = "William",
                UserAdress = "MorTest",
                UserPhoneNumber = "+46XXXXXXX3",
                UserAge = 28,
                UserIsTeacher = true,
                UserCityID = 18133,
            });

            modelBuilder.Entity<Location>()
            .HasData(new
            {
                LocationID = 1,
                LocationName = "Fjäderborgen",
                LocationCityID= 18153,
            }
            , new
            {
                LocationID=2,
                LocationName = "The Castle With Zero Books...",
                LocationCityID= 18133,
            });

            modelBuilder.Entity<Event>()
            .HasData(new
            {
                EventID = 1,
                EventName = "Lets Do some Awsome Curling",
                EventHobbyID = 297,
                EventResposibleID = 1,
                EventCityID = 18153,
            }    
            , new
            {
                EventID = 2,
                EventName = "BookClub All About The Books",
                EventHobbyID = 922,
                EventResposibleID = 3,
                EventCityID = 18133,
            });

            modelBuilder.Entity<HobbyLocation>()
            .HasData(new
            {
                HobbyID = 297,
                LocationID = 1,
            }
            , new
            {
                HobbyID = 922,
                LocationID = 2,
            });

            modelBuilder.Entity<HobbyUser>()
            .HasData(new
            {
                UserID = 1,
                HobbyID = 297,
            }
            , new
            {
                UserID = 2,
                HobbyID = 297,
            }
            , new
            {
                UserID = 3,
                HobbyID = 922,
            });

            string citiesPath = @"../Documentation/DataSets/world-cities.txt";
            string[] lines = System.IO.File.ReadAllLines(citiesPath);
            var count = 1;

            foreach (var line in lines)
            {

                string[] split = line.Split(',');
                City city = new City
                {
                    CityID = count,
                    CityName = split[0],
                    CityCountry = split[1],
                    CityCounty = split[2],
                };

                modelBuilder.Entity<City>().HasData(city);
                count += 1;
            }

            string hobbiesPath = @"../Documentation/DataSets/HobbiesList.txt";
            string[] hobbies = System.IO.File.ReadAllLines(hobbiesPath);
            count = 1;
            foreach (var hobbie in hobbies)
            {
                Hobby hobby = new Hobby
                {
                    HobbyID = count,
                    HobbyName = hobbie,
                };
                modelBuilder.Entity<Hobby>().HasData(hobby);
                count += 1;
            }
        }
    }
}