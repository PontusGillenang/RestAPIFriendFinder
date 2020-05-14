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
        private readonly FriendFinderContext _context;
        private readonly IEventRepository _eventRepository;

        public EventsController(FriendFinderContext context, IEventRepository eventRepository)
        {
            _context = context;
            _eventRepository = eventRepository;
        }

        //GET:      api/v1.0/events
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Event>>> GetEvents()
        {
            try
            {
                var results = await _eventRepository.GetHobbies();
                return Ok(results);
            }
            catch(Exception e)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Database Failure: {e.Message}");
            }
        }

        //GET:      api/v1.0/events/n
         [HttpGet("{id}")]
          public async Task<ActionResult<Event>> GetEventsByID(int id)
        {
            try
            {              
                var result = await _eventRepository.GetHobby(id);
                if(result == null)
                    return NotFound();

                return result;
            }
            catch(Exception e)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Database Failure: {e.Message}");
            }
          }
         //POST:      api/v1.0/events
         [HttpPost]
         public ActionResult<Event> PostEvents(Event eventPost)
         {
             _context.Events.Add(eventPost);
             //Important to not forget to save the changes in context when using POST
             _context.SaveChanges();

             return CreatedAtAction("GetEvent", new Event{EventID = eventPost.EventID}, eventPost);
            
         }

         //PUT:      api/v1.0/events/n
         [HttpPut("{id}")]
         public ActionResult PutEvent(int id, Event eventPut)
        {
            if(id != eventPut.EventID)
                return BadRequest();
            
             _context.Entry(eventPut).State = EntityState.Modified;
             /* Above code line makes the changes that we want in our context,
            which means that when we save context it will save those changes and get rid of previous value */

             _context.SaveChanges();

             // Because of the changes has already been done, we do not need to return any content.
             // That´s why we return method NoContent. So we kinda return a NoContent object. => Returns a "204 NoContent" Status

            return NoContent();
         }

         //DELETE:       api/v1.0/events/n
         [HttpDelete("{id}")]
         public ActionResult<Event> DeleteEvent(int id)
        {
             var eventDel = _context.Events.Find(id);
             if(eventDel == null)
                return NotFound();
            
             _context.Events.Remove(eventDel);
             _context.SaveChanges();

            return eventDel;
         }

    }
}