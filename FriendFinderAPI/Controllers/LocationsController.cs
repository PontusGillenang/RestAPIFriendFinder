using System.Collections.Generic;
using FriendFinderAPI.Context;
using FriendFinderAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace FriendFinderAPI.Controllers
{
   
    [Route("api/v1.0/[controller]")]
    [ApiController]
    public class LocationsController : ControllerBase
    {
        private readonly FriendFinderContext _context;

        public LocationsController(FriendFinderContext context) => _context = context;

        //GET:      api/v1.0/locations
        [HttpGet]
        public ActionResult<IEnumerable<Location>> GetLocations() => _context.Locations;

        //GET:      api/v1.0/locations/n
        [HttpGet("{id}")]
        public ActionResult<Location> GetLocationByID(int id)
        {
            var location = _context.Locations.Find(id);
            if(location == null)
                return NotFound();
            
            return location;
        }

        //POST:      api/v1.0/locations
        [HttpPost]
        public ActionResult<Location> PostLocation(Location location)
        {
            _context.Locations.Add(location);
            //Important to dont forget that save the changes in context when using POST
            _context.SaveChanges();

            return CreatedAtAction("GetLocation", new Location{LocationID = location.LocationID}, location);
        }

        //PUT:      api/v1.0/locations/n
        [HttpPut("{id}")]
        public ActionResult PutLocation(int id, Location location)
        {
            if(id != location.LocationID)
                return BadRequest();
            
            _context.Entry(location).State = EntityState.Modified;
            // Above code line make the changes to we want, in our context,
            // Which means that when we Save context it will save those changes and get rid of previous value

            _context.SaveChanges();

            // Because of that the changes already been done, we do not need to return any content.
            // That´s why we return method NoContent. So we kinda returns a NoContent object. => Returns a "204 NoContent" Status

            return NoContent();
        }

        //DELETE:       api/v1.0/locations/n
        [HttpDelete("{id}")]
        public ActionResult<Location> DeleteLocation(int id)
        {
            var location = _context.Locations.Find(id);
            if(location == null)
                return NotFound();
            
            _context.Locations.Remove(location);
            _context.SaveChanges();

            return location;
        }
        
    }
    }
}
