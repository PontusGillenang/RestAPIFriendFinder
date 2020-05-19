using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using FriendFinderAPI.Models;
using System.Collections.Generic;

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
        public virtual DbSet<EventUser> EventUsers { get; set; }

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

            // modelBuilder.Entity<User>()
            // .HasRequired<User>(u => u.User)
            // .WithMany(u => u.Event);

            modelBuilder.Entity<EventUser>()
            .HasKey(bc => new { bc.EventID, bc.UserID });  
            modelBuilder.Entity<EventUser>()
            .HasOne(bc => bc.Event)
            .WithMany(b => b.EventUsers)
            .HasForeignKey(bc => bc.EventID);  
            modelBuilder.Entity<EventUser>()
            .HasOne(bc => bc.User)
            .WithMany(c => c.EventUsers)
            .HasForeignKey(bc => bc.UserID)
            .OnDelete(DeleteBehavior.NoAction);

            // modelBuilder.Entity<Event>()
            // .HasOne(e => e.EventResposibleUser)
            // .WithMany(h => h.Event)
            // .HasForeignKey(hl => hl.);

            // modelBuilder.Entity<City>()
            // .HasMany<User>(c=> c.CityUsers)
            // .WithOne(u=>u.UserCity)
            // .HasForeignKey(u=> u.UserCityID);
            // .OnDelete(DeleteBehavior.ClientSetNull);

            // modelBuilder.Entity<Event>()
            // .HasKey(hu => new { hu.EventID, hu.EventUserID });

            // modelBuilder.Entity<User>()
            // .HasOne(u=> u.UserCity)
            // .WithMany(c=> c.CityUsers)
            // .OnDelete(DeleteBehavior.NoAction);

            string citiesPath = @"../Documentation/DataSets/world-cities.txt";
            string[] lines = System.IO.File.ReadAllLines(citiesPath);
            List<City> tempCities = new List<City>();
            for (int i = 1; i < 4; i++)
            {
                string[] split = lines[i].Split(',');
                City city = new City
                {
                    CityID = i,
                    CityName = split[0],
                    CityCountry = split[1],
                    CityCounty = split[2],
                };
                tempCities.Add(city);
                modelBuilder.Entity<City>().HasData(city);
                
            }

            modelBuilder.Entity<User>()
            .HasData(new
            {
                UserID = 1,
                UserName = "Sebbe",
                UserAdress = "Drottninggatan",
                UserPhoneNumber = "+46XXXXXXX",
                UserAge = 20,
                UserIsTeacher = true,
                UserCityID = 2
            }
            , new
            {
                UserID = 2,
                UserName = "Oskar",
                UserAdress = "Kungsgatan",
                UserPhoneNumber = "+46XXXXXXX2",
                UserAge = 22,
                UserIsTeacher = false,
                UserCityID = 1
            }
            , new
            {
                UserID = 3,
                UserName = "William",
                UserAdress = "MorTest",
                UserPhoneNumber = "+46XXXXXXX3",
                UserAge = 28,
                UserIsTeacher = true,
                UserCityID = 1
            });

            modelBuilder.Entity<Location>()
            .HasData(new
            {
                LocationID = 1,
                LocationName = "Fjäderborgen",
                LocationCityID= 2,
            }
            , new
            {
                LocationID=2,
                LocationName = "The Castle With Zero Books...",
                LocationCityID= 1,
            });

            modelBuilder.Entity<Event>()
            .HasData(new
            {
                EventID = 1,
                EventName = "Lets Do some Awsome Curling",
                //EventHobbyID = 297,
                EventHobbyID = 2,
                EventResposibleUserID = 1,
                EventCityID = 1,
            }    
            , new
            {
                EventID = 2,
                EventName = "BookClub All About The Books",
                //EventHobbyID = 922,
                EventHobbyID = 1,
                EventResposibleUserID = 3,
                EventCityID = 2,
            });

            modelBuilder.Entity<HobbyLocation>()
            .HasData(new
            {
                HobbyID = 1,
                LocationID = 1,
            }
            , new
            {
                HobbyID = 2,
                LocationID = 2,
            });

            modelBuilder.Entity<HobbyUser>()
            .HasData(new
            {
                UserID = 1,
                HobbyID = 1,
            }
            , new
            {
                UserID = 2,
                HobbyID = 2,
            }
            , new
            {
                UserID = 3,
                HobbyID = 3,
            });


            string hobbiesPath = @"../Documentation/DataSets/HobbiesList.txt";
            string[] hobbies = System.IO.File.ReadAllLines(hobbiesPath);

            for (int i = 1; i < 4; i++)
            {
                Hobby hobby = new Hobby
                {
                    HobbyID = i,
                    HobbyName = hobbies[i],
                };
                modelBuilder.Entity<Hobby>().HasData(hobby);
            }
        }
    }
}