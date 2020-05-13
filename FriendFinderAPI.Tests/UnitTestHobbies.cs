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
        [Fact]

        public async void GetTeachersByHobbyTest()
        {
             IList<Hobby> hobbies = GenerateHobbies();
            var FriendFinderContextMock = new Mock<FriendFinderContext>();
            FriendFinderContextMock.Setup(h=>h.Hobbies).ReturnsDbSet(hobbies);

            var logger = Mock.Of<ILogger<HobbyRepository>>();
            var hobbyRepository = new HobbyRepository(FriendFinderContextMock.Object, logger);

            //Act
            var result = await hobbyRepository.GetTeachersByHobby(1);

            //Assert
            Assert.Equal(1, (int)result[0].HobbyUsers.Count);
        }
        private static IList<Hobby> GenerateHobbies()
        {
        User testUser = new User{
                     UserID = 1,
                     UserName = "Sebbe",
                     UserAdress = "Test",
                     UserPhoneNumber = "Test",
                     UserAge = 20,
                     UserIsTeacher = true,
                 };
       

        ICollection<HobbyUser> TestList = new List<HobbyUser>();
        TestList.Add(new HobbyUser{
            HobbyID = 1,
            UserID = 1,
            User = testUser,
            
        });
           
      return new List<Hobby> 
        {
         new Hobby
            {
           HobbyActivationLevel = HobbyActivationLevel.Skilled,
             HobbyID = 1,
             HobbyName = "Badminton",
             HobbyUsers = TestList
            },
            new Hobby{
            HobbyActivationLevel = HobbyActivationLevel.Expert,
             HobbyID = 2,
             HobbyName = "Curling"
            
            }

        };

        //TestListHobby.Add(testHobby);
    }
    }
}