using System.Collections.Generic;
using FriendFinderAPI.Context;
using FriendFinderAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FriendFinderAPI.Controllers
{
    [Route("api/v1.0/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        private readonly FriendFinderContext _context;

        public EventsController(FriendFinderContext context) => _context = context;

        //GET:      api/v1.0/events
        [HttpGet]
        public ActionResult<IEnumerable<Event>> GetEvents() => _context.Events;



        //GET:      api/v1.0/events/n
         [HttpGet("{id}")]
         public ActionResult<Event> GetEventsByID(int id)
        {
            //  var event = _context.Events.Find(id);
            // if(event == null)
            //     return NotFound();
           
             return null;
              var event = _context.Events.Find(id);
         }
        // //POST:      api/v1.0/events
        // [HttpPost]
        // public ActionResult<Event> PostEvents(Event event)
        // {
        //     _context.Events.Add(Event);
        //     //Important to dont forget that save the changes in context when using POST
        //     _context.SaveChanges();

        //     return CreatedAtAction("GetEvent", new Event{EventID = event.EventID}, Event);
        // }

        // //PUT:      api/v1.0/events/n
        // [HttpPut("{id}")]
        // public ActionResult PutEvent(int id, Event event)
        // {
        //     if(id != event.EventID)
        //         return BadRequest();
            
        //     _context.Entry(event).State = EntityState.Modified;
        //     // Above code line make the changes to we want, in our context,
        //     // Which means that when we Save context it will save those changes and get rid of previous value

        //     _context.SaveChanges();

        //     // Because of that the changes already been done, we do not need to return any content.
        //     // That´s why we return method NoContent. So we kinda returns a NoContent object. => Returns a "204 NoContent" Status

        //     return NoContent();
        // }

        // //DELETE:       api/v1.0/cities/n
        // [HttpDelete("{id}")]
        // public ActionResult<City> DeleteEvent(int id)
        // {
        //     var event = _context.Events.Find(id);
        //     if(event == null)
        //         return NotFound();
            
        //     _context.Events.Remove(event);
        //     _context.SaveChanges();

        //     return event;
        // }

    }
}