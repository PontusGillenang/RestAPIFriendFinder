using System;
using System.IO;
using FriendFinderAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using static FriendFinderAPI.Enums.Enums;

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
            IConfigurationRoot configuration = new ConfigurationBuilder()
                                                            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                                                            .AddJsonFile("appsettings.json")
                                                            .AddJsonFile("appsettings.Development.json")
                                                            .Build();
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("FriendFinderAPIConnection"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<Link>();


            modelBuilder.Entity<HobbyUser>()
            .HasKey(hu => new { hu.HobbyId, hu.UserId });

            modelBuilder.Entity<HobbyUser>()
            .HasOne(hu => hu.Hobby)
            .WithMany(h => h.HobbyUsers)
            .HasForeignKey(hu => hu.HobbyId);

            modelBuilder.Entity<HobbyUser>()
            .HasOne(hu => hu.User)
            .WithMany(h => h.HobbyUsers)
            .HasForeignKey(hu => hu.UserId);


            modelBuilder.Entity<HobbyLocation>()
            .HasKey(hl => new { hl.HobbyId, hl.LocationId });

            modelBuilder.Entity<HobbyLocation>()
            .HasOne(hl => hl.Hobby)
            .WithMany(h => h.HobbyLocations)
            .HasForeignKey(hl => hl.HobbyId);

            modelBuilder.Entity<HobbyLocation>()
            .HasOne(hl => hl.Location)
            .WithMany(h => h.HobbyLocations)
            .HasForeignKey(hl => hl.LocationId);


            modelBuilder.Entity<EventUser>()
            .HasKey(bc => new { bc.EventId, bc.UserId });

            modelBuilder.Entity<EventUser>()
            .HasOne(bc => bc.Event)
            .WithMany(b => b.EventUsers)
            .HasForeignKey(bc => bc.EventId);

            modelBuilder.Entity<EventUser>()
            .HasOne(bc => bc.User)
            .WithMany(c => c.EventUsers)
            .HasForeignKey(bc => bc.UserId)
            .OnDelete(DeleteBehavior.NoAction);
            

            string citiesPath = @"../Documentation/DataSets/cities.txt";
            string[] lines = File.ReadAllLines(citiesPath);
            for (int i = 0; i < 5; i++)
            {
                string[] split = lines[i].Split(',');
                City city = new City
                {
                    CityId = i+1,
                    CityName = split[0],
                    CityCountry = split[1],
                    CityCounty = split[2],
                };
                modelBuilder.Entity<City>().HasData(city);
            }

            modelBuilder.Entity<User>()
            .HasData(new
            {
                UserId = 1,
                UserName = "Sebbe Persson",
                UserAdress = "Drottninggatan 2",
                UserPhoneNumber = "+46XXXXXXX",
                UserAge = 20,
                CityId = 1
            }
            , new
            {
                UserId = 2,
                UserName = "Peder Åborg",
                UserAdress = "Knudsgate 15",
                UserPhoneNumber = "+45XXXXXXX1",
                UserAge = 22,
                CityId = 5
            }
            , new
            {
                UserId = 3,
                UserName = "Petra Levinman",
                UserAdress = "Karl Andersgatan 6",
                UserPhoneNumber = "+46XXXXXXX2",
                UserAge = 24,
                CityId = 3
            }
            , new
            {
                UserId = 4,
                UserName = "Pontus Bergman",
                UserAdress = "Beringsväg 10",
                UserPhoneNumber = "+47XXXXXXX3",
                UserAge = 25,
                CityId = 4
            }
            , new
            {
                UserId = 5,
                UserName = "Olle Kvist",
                UserAdress = "Kongasnåret 1",
                UserPhoneNumber = "+47XXXXXXX4",
                UserAge = 43,
                CityId = 4
            }
            , new
            {
                UserId = 6,
                UserName = "Christina Kerlpalm",
                UserAdress = "Gregorstande 6",
                UserPhoneNumber = "+45XXXXXXX5",
                UserAge = 32,
                CityId = 5
            }
            , new
            {
                UserId = 7,
                UserName = "Osborn Börjesson",
                UserAdress = "Kungsportsavenyn 3",
                UserPhoneNumber = "+46XXXXXXX6",
                UserAge = 34,
                CityId = 1
            }
            , new
            {
                UserId = 8,
                UserName = "Pelle Plutter",
                UserAdress = "Djurgårdsvägen 21",
                UserPhoneNumber = "+46XXXXXXX7",
                UserAge = 26,
                CityId = 2
            }
            , new
            {
                UserId = 9,
                UserName = "Ina Pålström",
                UserAdress = "Vättlegatan 2",
                UserPhoneNumber = "+46XXXXXXX8",
                UserAge = 27,
                CityId = 2
            }
            , new
            {
                UserId = 10,
                UserName = "William Morberg",
                UserAdress = "Opalgatan 54",
                UserPhoneNumber = "+46XXXXXXX9",
                UserAge = 28,
                CityId = 3
            });

            modelBuilder.Entity<Location>()
            .HasData(new
            {
                LocationId = 1,
                LocationName = "Chalmers Tekniska Högskola",
                CityId = 1,
            }
            , new
            {
                LocationId = 2,
                LocationName = "Haga Teatern",
                CityId = 1,
            }
            , new
            {
                LocationId = 3,
                LocationName = "Skansen",
                CityId = 2,
            }
            , new
            {
                LocationId = 4,
                LocationName = "Södermalm",
                CityId = 2,
            }
            , new
            {
                LocationId = 5,
                LocationName = "Stora Torget",
                CityId = 3,
            }
            , new
            {
                LocationId = 6,
                LocationName = "Triangeln",
                CityId = 3,
            }
            , new
            {
                LocationId = 7,
                LocationName = "Kampen",
                CityId = 4,
            }
            , new
            {
                LocationId = 8,
                LocationName = "Domkirke",
                CityId = 4,
            }
            , new
            {
                LocationId = 9,
                LocationName = "Nyhavn",
                CityId = 5,
            }
            , new
            {
                LocationId = 10,
                LocationName = "Nytorv",
                CityId = 5,
            });

            modelBuilder.Entity<Event>()
            .HasData(new
            {
                EventId = 1,
                EventName = "3D Print Workshop",
                HobbyId = 1,
                CityId = 1,
            }
            , new
            {
                EventId = 2,
                EventName = "Beginners Acting Club",
                HobbyId = 2,
                CityId = 1,
            }
            , new
            {
                EventId = 3,
                EventName = "Amatuer Airsoft Mayhem",
                HobbyId = 4,
                CityId = 2,
            }
            , new
            {
                EventId = 4,
                EventName = "Malmö for Biathlon in the World",
                HobbyId = 8,
                CityId = 3,
            }
            , new
            {
                EventId = 5,
                EventName = "Nightime in Oslo with The Stars",
                HobbyId = 6,
                CityId = 4,
            }
            , new
            {
                EventId = 6,
                EventName = "Danske Ølefest me Beer Pong",
                HobbyId = 7,
                CityId = 5,
            });

            modelBuilder.Entity<HobbyLocation>()
            .HasData(new
            {
                HobbyId = 1,
                LocationId = 1,
            }
            , new
            {
                HobbyId = 2,
                LocationId = 2,
            }
            , new
            {
                HobbyId = 4,
                LocationId = 3,
            }
            , new
            {
                HobbyId = 6,
                LocationId = 6,
            }
            , new
            {
                HobbyId = 7,
                LocationId = 9,
            }
            , new
            {
                HobbyId = 8,
                LocationId = 6,
            });

            modelBuilder.Entity<EventUser>()
            .HasData(new
            {
                EventId = 1,
                UserId = 1,
                UserIsResponsible = true
            }
            , new
            {
                EventId = 1,
                UserId = 2,
                UserIsResponsible = false
            }
            , new
            {
                EventId = 3,
                UserId = 3,
                UserIsResponsible = true
            }
            , new
            {
                EventId = 3,
                UserId = 4,
                UserIsResponsible = false
            }
            , new
            {
                EventId = 4,
                UserId = 5,
                UserIsResponsible = true
            }
            , new
            {
                EventId = 4,
                UserId = 6,
                UserIsResponsible = false
            }
            , new
            {
                EventId = 5,
                UserId = 7,
                UserIsResponsible = true
            }
            , new
            {
                EventId = 5,
                UserId = 8,
                UserIsResponsible = false
            }
            , new
            {
                EventId = 6,
                UserId = 9,
                UserIsResponsible = true
            }
            , new
            {
                EventId = 6,
                UserId = 10,
                UserIsResponsible = false
            });

            modelBuilder.Entity<HobbyUser>()
            .HasData(new
            {
                UserId = 1,
                HobbyId = 1,
                SkillLevel = UserSkillLevel.Master
            }
            , new
            {
                UserId = 2,
                HobbyId = 1,
                SkillLevel = UserSkillLevel.Intermediate
            }
            , new
            {
                UserId = 3,
                HobbyId = 3,
                SkillLevel = UserSkillLevel.Advanced
            }
            , new
            {
                UserId = 4,
                HobbyId = 3,
                SkillLevel = UserSkillLevel.Beginner
            }
            , new
            {
                UserId = 5,
                HobbyId = 8,
                SkillLevel = UserSkillLevel.Intermediate
            }
            , new
            {
                UserId = 6,
                HobbyId = 8,
                SkillLevel = UserSkillLevel.Beginner
            }
            , new
            {
                UserId = 7,
                HobbyId = 6,
                SkillLevel = UserSkillLevel.Beginner
            }
            , new
            {
                UserId = 8,
                HobbyId = 6,
                SkillLevel = UserSkillLevel.Advanced
            }
            , new
            {
                UserId = 9,
                HobbyId = 7,
                SkillLevel = UserSkillLevel.Advanced
            }
            , new
            {
                UserId = 10,
                HobbyId = 7,
                SkillLevel = UserSkillLevel.Intermediate
            });

            string hobbiesPath = @"../Documentation/DataSets/HobbiesList.txt";
            string[] hobbies = File.ReadAllLines(hobbiesPath);
            for (int i = 0; i < 10; i++)
            {
                Hobby hobby = new Hobby
                {
                    HobbyId = i+1,
                    HobbyName = hobbies[i],
                };
                modelBuilder.Entity<Hobby>().HasData(hobby);
            }
        }
    }
}