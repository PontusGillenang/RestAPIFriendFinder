using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using FriendFinderAPI.Models;

namespace FriendFinderAPI.Context
{
    public class FriendFinderContext : DbContext
    {
        private readonly IConfiguration _configuration;
        public FriendFinderContext(){}
        public FriendFinderContext(IConfiguration config , DbContextOptions options) : base (options)
        {
            _configuration = config;
        }

        public virtual DbSet<User> Users {get; set;}
        public virtual DbSet<City> Cities {get; set;}
        public virtual DbSet<Hobby> Hobbies {get; set;}
        public virtual DbSet<Location> Locations {get; set;}
        public virtual DbSet<Match> Matches {get; set;}
        public virtual DbSet<Event> Events {get; set;} 

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

            // modelBuilder.Entity<City>()
            // .HasData(new{
            // CityID = 1,
            // CityName ="Göteborg",
            // CityCountry = "Sweden",
            // CityCounty = "Västra Götaland"
            // }, new{
            // CityID = 2,
            // CityName ="Malmo",
            // CityCountry = "Denmark",
            // CityCounty = "Malmo"
            // }, new{
            // CityID = 3,
            // CityName ="Stockholm",
            // CityCountry = "Sweden",
            // CityCounty = "Stockholm"
            // });

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


            string filePath = "./Documentation/DataSets/world-cities.csv";
            string[] lines= System.IO.File.ReadAllLines(filePath);

            foreach (var line in lines)
            {
                string[] split = line.Split(',');
                City c= new City{
                    CityName= split[0],c
                    CityCountry= split[1],
                    CityCounty= split[2],
                };
                modelBuilder.Entity<City>().HasData(c);
            }
        }
    }
}