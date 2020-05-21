using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FriendFinderAPI.Context;
using FriendFinderAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FriendFinderAPI.Services;
using FriendFinderAPI.Dtos;
using AutoMapper;

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

        //GET:      api/v1.0/events
        [HttpGet( Name = "GetEvents")]
        public async Task<ActionResult<IEnumerable<Event>>> GetEvents()
        {
            try
            {
                var results = await _eventRepository.GetEvents();
                 for(int i = 0; i<results.Length;i++)
                 {
                        results[i].EventLink = CreateLinksGetAllLocations(results[i]);
                 }
                return Ok(results);
            }
            catch (Exception e)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Database Failure: {e.Message}");
            }
        }

        //GET:      api/v1.0/events/n

        [HttpGet("{id}",  Name = "GetEvent")]
        public async Task<ActionResult<Event>> GetEvent(int id)
        {
            try
            {
                var result = await _eventRepository.GetEvent(id);
                result.EventLink = CreateLinksGetLocation(result);
                if (result == null)
                    return NotFound();

                return result;
            }
            catch (Exception e)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Database Failure: {e.Message}");
            }
        }

        [HttpGet("hobby/{id}",  Name = "GetEventsByHobby")]
        public async Task<ActionResult<IEnumerable<Event>>> GetEventsByHobby(int id)
        {
            try
            {
                var results = await _eventRepository.GetEventsByHobby(id);
                return results;
            }
            catch(Exception e)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Database Failure: {e.Message}");
            }
        }

        [HttpGet("hobby/{hobbyid}/city/{cityid}", Name = "GetEventsByHobbyCity")]
       
        
        public async Task<ActionResult<IEnumerable<Event>>> GetEventsByHobbyCity(int hobbyid, int cityid)
        {
            try
            {
                var results = await _eventRepository.GetEventsByHobbyCity(hobbyid, cityid);
                return results;
            }
            catch(Exception e)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Database Failure: {e.Message}");
            }
        }

        [HttpGet("city{id}", Name = "GetEventsByCity")]
        public async Task<ActionResult<IEnumerable<Event>>> GetEventsByCity(int id)
        {
            try
            {
                var results = await _eventRepository.GetEventsByCity(id);
                return results;
            }
            catch(Exception e)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Database Failure: {e.Message}");
            }
        }

        //POST:      api/v1.0/events
        [HttpPost(Name = "PostEvent")]
        public async Task<ActionResult<EventDto>> PostEvents(EventDto eventDto)
        {
            try
            {
                var mappedEntity = _mapper.Map<EventDto>(eventDto);
                _eventRepository.Add(mappedEntity);

                if(await _eventRepository.Save())
                    return Created($"api/v1.0/cities/{mappedEntity.EventID}", _mapper.Map<EventDto>(mappedEntity));
            }
            catch (Exception e)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError,$"Database Failure: {e.Message}");
            }
            return BadRequest();
        }

        //PUT:      api/v1.0/events/n
        [HttpPut("{id}", Name = "PutEvent")]
        public async Task<ActionResult<EventDto>> PutEvent(int eventID, EventDto eventDto)
        {
            try
            {
                var oldEvent = await _eventRepository.GetEvent(eventID);
                if(oldEvent == null)
                    return NotFound($"Could not find the event with id {eventID}");
                
                var newEvent =_mapper.Map(eventDto, oldEvent);
                _eventRepository.Update(newEvent);

                if(await _eventRepository.Save())
                    return NoContent();
            }
            catch (Exception e)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError,$"Database Failure: {e.Message}");
            }
            return BadRequest();
        }

        //DELETE:       api/v1.0/events/n
        [HttpDelete("{id}", Name = "DeleteEvent")]
        public async Task<ActionResult> DeleteEvent(int eventID)
        {
            try
            {
                var eventToRemove = await _eventRepository.GetEvent(eventID);
                if(eventToRemove == null)
                    return NotFound($"Could not find an event with the id: {eventID}");
                
                _eventRepository.Delete(eventToRemove);
                if(await _eventRepository.Save())
                    return NoContent();
            }
            catch (Exception e)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError,$"Database Failure: {e.Message}");
            }
            return BadRequest();
        }
        private IEnumerable<Link> CreateLinksGetAllLocations(Event events)
        {
            var links = new[]
            {
            new Link{
            Method = "GET",
            Rel = "self",
            Href = Url.Link("GetEvent",new {id = events.EventID} ).ToLower()
            }
            };
            return links;
        }
        private IEnumerable<Link> CreateLinksGetLocation(Event events)
        {
            var links = new[]
            {
            new Link
            {
            Method = "GET",
            Rel = "self",
            Href = Url.Link("GetEvent", new {id = events.EventID}).ToLower()
            },
            new Link
            {
            Method = "DELETE",
            Rel = "self",
            Href = Url.Link("DeleteEventn", new {id = events.EventID}).ToLower()
            },
            new Link
            {
                Method = "PUT",
                Rel = "self",
                Href = Url.Link("PutEvent", new {id = events.EventID}).ToLower()
            }
            };
            return links;
        }

    }
}