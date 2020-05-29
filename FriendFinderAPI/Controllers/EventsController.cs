using AutoMapper;
using Castle.Core.Internal;
using FriendFinderAPI.Dtos;
using FriendFinderAPI.Models;
using FriendFinderAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FriendFinderAPI.Controllers
{
    [Route("api/v1.0/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        private readonly IEventRepository _eventRepository;
        private readonly IMapper _mapper;

        public EventsController(IEventRepository eventRepository, IMapper mapper)
        {
            _eventRepository = eventRepository;
            _mapper = mapper;
        }

        [HttpGet(Name = "GetEvents")]
        public async Task<ActionResult<EventDto[]>> GetEvents(bool includeUsers)
        {
            try
            {
                var results = await _eventRepository.GetEvents(includeUsers);
                var mappedResults = _mapper.Map<EventDto[]>(results);

                if (mappedResults.IsNullOrEmpty())
                {
                    return NotFound();
                }

                for (int i = 0; i < mappedResults.Length; i++)
                {
                    mappedResults[i].Links = CreateLinksGetAllEvents(mappedResults[i]);
                }

                return Ok(mappedResults);
            }
            catch (Exception exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Database Failure: {exception.Message}");
            }
        }

        [HttpGet("{eventId}", Name = "GetEvent")]
        public async Task<ActionResult<EventDto>> GetEvent(int eventId, bool includeUsers)
        {
            try
            {
                var result = await _eventRepository.GetEvent(eventId, includeUsers);
                var mappedResult = _mapper.Map<EventDto>(result);

                if (mappedResult == null)
                {
                    return NotFound();
                }

                mappedResult.Links = CreateLinksGetAllEvents(mappedResult);

                return Ok(mappedResult);
            }
            catch (Exception exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Database Failure: {exception.Message}");
            }
        }

        [HttpGet("searchhobby", Name = "GetEventsByHobby")]
        public async Task<ActionResult<EventDto[]>> GetEventsByHobby(string hobbyName, bool includeUsers)
        {
            try
            {
                var results = await _eventRepository.GetEventsByHobby(hobbyName, includeUsers);
                var mappedResults = _mapper.Map<EventDto[]>(results);

                if (mappedResults.IsNullOrEmpty())
                {
                    return NotFound();
                }

                return Ok(mappedResults);
            }
            catch (Exception exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Database Failure: {exception.Message}");
            }
        }

        [HttpGet("searchcity", Name = "GetEventsByCity")]
        public async Task<ActionResult<EventDto[]>> GetEventsByCity(string cityName, bool includeUsers)
        {
            try
            {
                var results = await _eventRepository.GetEventsByCity(cityName, includeUsers);
                var mappedResults = _mapper.Map<EventDto[]>(results);

                if (mappedResults.IsNullOrEmpty())
                {
                    return NotFound();
                }
                                
                return Ok(mappedResults);
            }
            catch (Exception exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Database Failure: {exception.Message}");
            }
        }

        [HttpPost(Name = "PostEvent")]
        public async Task<ActionResult<EventDto>> PostEvents(EventDto eventDto)
        {
            try
            {
                var mappedEntity = _mapper.Map<Event>(eventDto);
                _eventRepository.Add(mappedEntity);

                if (await _eventRepository.Save())
                {
                    return Created($"/api/v1.0/events/{mappedEntity.EventId}", _mapper.Map<EventDto>(mappedEntity));
                }
            }
            catch (Exception exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Database Failure: {exception.Message}");
            }
            return BadRequest();
        }

        [HttpPut("{eventId}", Name = "PutEvent")]
        public async Task<ActionResult<EventDto>> PutEvent(int eventId, bool includeUsers, EventDto eventDto)
        {
            try
            {
                var existingEvent = await _eventRepository.GetEvent(eventId, includeUsers);

                if (existingEvent == null)
                {
                    return NotFound($"Could not find the event with id {eventId}");
                }

                var newEvent = _mapper.Map(eventDto, existingEvent);
                _eventRepository.Update(newEvent);

                if (await _eventRepository.Save())
                {
                    return NoContent();
                }
            }
            catch (Exception exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Database Failure: {exception.Message}");
            }
            return BadRequest();
        }

        [HttpDelete("{eventId}", Name = "DeleteEvent")]
        public async Task<ActionResult> DeleteEvent(int eventId, bool includeUsers)
        {
            try
            {
                var eventToRemove = await _eventRepository.GetEvent(eventId, includeUsers);
                
                if (eventToRemove == null)
                {
                    return NotFound($"Could not find an event with the id: {eventId}");
                }

                _eventRepository.Delete(eventToRemove);
                
                if (await _eventRepository.Save())
                {
                    return NoContent();
                }
            }
            catch (Exception exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Database Failure: {exception.Message}");
            }
            return BadRequest();
        }

        private IEnumerable<Link> CreateLinksGetAllEvents(EventDto events)
        {
            var links = new[]
            {
            new Link
            {
            Method = "GET",
            Rel = "self",
            Href = Url.Link("GetEvent", new {eventId = events.EventId}).ToLower()
            },
            new Link
            {
            Method = "DELETE",
            Rel = "self",
            Href = Url.Link("DeleteEvent", new {eventId = events.EventId}).ToLower()
            },
            new Link
            {
            Method = "PUT",
            Rel = "self",
            Href = Url.Link("PutEvent", new {eventId = events.EventId}).ToLower()
            },
            };
            return links;
        }
    }
}