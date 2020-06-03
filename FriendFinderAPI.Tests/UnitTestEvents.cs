using FriendFinderAPI.Context;
using FriendFinderAPI.Models;
using FriendFinderAPI.Services;
using Microsoft.Extensions.Logging;
using Moq;
using Moq.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using Xunit;

namespace FriendFinderAPI.Tests
{
    public class UnitTestEvents
    {
        [Fact]
        public async void EventRepository_GetEventsTest()
        {
            //Arrange
            IList<Event> events = GenerateEvents();
            var FriendFinderContextMock = new Mock<FriendFinderContext>();
            FriendFinderContextMock.Setup(events => events.Events).ReturnsDbSet(events);

            var logger = Mock.Of<ILogger<EventRepository>>();
            var eventRepository = new EventRepository(FriendFinderContextMock.Object, logger);

            //Act
            var result = await eventRepository.GetEvents();

            //Assert
            Assert.Equal(2, result.Length);
            Assert.Equal("First Event", result[0].EventName);
            Assert.Equal("Second Event", result[1].EventName);
        }

        [Fact]
        public async void EventRepository_GetEventByIdTest()
        {
            //Arrange
            IList<Event> events = GenerateEvents();
            var FriendFinderContextMock = new Mock<FriendFinderContext>();
            FriendFinderContextMock.Setup(events => events.Events).ReturnsDbSet(events);

            var logger = Mock.Of<ILogger<EventRepository>>();
            var eventRepository = new EventRepository(FriendFinderContextMock.Object, logger);

            //Act
            var result = await eventRepository.GetEvent(1);

            //Assert
            Assert.Equal(1, result.EventId);
        }

        private static IList<Event> GenerateEvents()
        {
            return new List<Event>
            {
                new Event
                {
                    EventId = 1,
                    EventName = "First Event",
                    EventStart = new DateTime(2020,01,01,10,00,00),
                    EventEnd = new DateTime(2020,01,01,11,00,00)
                },
                new Event
                {
                    EventId = 2,
                    EventName = "Second Event",
                    EventStart = new DateTime(2020,01,02,10,00,00),
                    EventEnd = new DateTime(2020,01,02,11,00,00)
                }
            };
        }
    }
}