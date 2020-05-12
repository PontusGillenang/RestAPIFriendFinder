using System;
using Xunit;
using System.Collections;
using System.Collections.Generic;
using FriendFinderAPI.Context;
using FriendFinderAPI.Services;
using FriendFinderAPI.Models;
using Microsoft.Extensions.Logging;
using Moq;
using Moq.EntityFrameworkCore;

namespace FriendFinderAPI.Tests
{
    public class TestClass
    {
    
        [Fact]
        public async void GetHobbiesTest()
        {
            //Arrange
            IList<Hobby> hobbies = GenerateHobbies();
            var FriendFinderContextMock = new Mock<FriendFinderContext>();
            FriendFinderContextMock.Setup(h=>h.Hobbies).ReturnsDbSet(hobbies);

            var logger = Mock.Of<ILogger<HobbyRepository>>();
            var hobbyRepository = new HobbyRepository(FriendFinderContextMock.Object, logger);

            //Act
            var result = await hobbyRepository.GetHobbies();

            //Assert
            Assert.Equal(2, (int)result.Length);
        }
        [Fact]
        public async void GetHobbyTest()
        {
            IList<Hobby> hobbies = GenerateHobbies();
            var FriendFinderContextMock = new Mock<FriendFinderContext>();
            FriendFinderContextMock.Setup(h=>h.Hobbies).ReturnsDbSet(hobbies);

            var logger = Mock.Of<ILogger<HobbyRepository>>();
            var hobbyRepository = new HobbyRepository(FriendFinderContextMock.Object, logger);
            //Act
            var result = await hobbyRepository.GetHobby(2);

            //Assert
            Assert.Equal(2, result.HobbyID);
            
        }
        
        private static IList<Hobby> GenerateHobbies()
        {
        return new List<Hobby>
        {
            new Hobby
            {
           HobbyActivationLevel = HobbyActivationLevel.Skilled,
             HobbyID = 1,
             HobbyName = "Badminton"
            },
            new Hobby{
            HobbyActivationLevel = HobbyActivationLevel.Expert,
             HobbyID = 2,
             HobbyName = "Curling"
            
            }

        };
    }
    }
}