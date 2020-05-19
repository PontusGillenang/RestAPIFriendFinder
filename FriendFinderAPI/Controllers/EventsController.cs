using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FriendFinderAPI.Context;
using FriendFinderAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FriendFinderAPI.Services;

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
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Event>>> GetEvents()
        {
            try
            {
                var results = await _eventRepository.GetEvents();
                return Ok(results);
            }
            catch (Exception e)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Database Failure: {e.Message}");
            }
        }

        //GET:      api/v1.0/events/n

        [HttpGet("{id}")]
        public async Task<ActionResult<Event>> GetEvent(int id)
        {
            try
            {
                var result = await _eventRepository.GetEvent(id);
                if (result == null)
                    return NotFound();

                return result;
            }
            catch (Exception e)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Database Failure: {e.Message}");
            }
        }

        [HttpGet("{id}")]
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

        [HttpGet("{hobbyid}, {cityid}")]
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

        [HttpGet("{id}")]
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
        [HttpPost]
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
        [HttpPut("{id}")]
        public async Task<ActionResult<EventDto>> PutEvent(EventDto eventDto)
        {
            try
            {
                var mappedEntity =_mapper.Map<EventDto>(eventDto);
                _eventRepository.Update(mappedEntity);

                if(await _eventRepository.Save())
                    return Created($"api/v1.0/cities/{mappedEntity.EventID}", _mapper.Map<EventDto>(mappedEntity));
            }
            catch (Exception e)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError,$"Database Failure: {e.Message}");
            }
            return BadRequest();
        }

        //DELETE:       api/v1.0/events/n
        [HttpDelete("{id}")]
        public async Task<ActionResult<EventDto>> DeleteEvent(EventDto eventDto)
        {
            try
            {
                var mappedEntity = _mapper.Map<EventDto>(eventDto);
                _eventRepository.Delete(mappedEntity);

                if(await _eventRepository.Save())
                    return Created($"api/v1.0/cities/{mappedEntity.EventID}", _mapper.Map<EventDto>(mappedEntity));
            }
            catch (Exception e)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError,$"Database Failure: {e.Message}");
            }
            return BadRequest();
        }

    }
}