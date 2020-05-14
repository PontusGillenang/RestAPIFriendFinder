using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FriendFinderAPI.Context;
using FriendFinderAPI.Models;
using FriendFinderAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace FriendFinderAPI.Controllers
{
   
    [Route("api/v1.0/[controller]")]
    [ApiController]
    public class LocationsController : ControllerBase
    {
        private readonly FriendFinderContext _context;
        private readonly ILocationRepository _locationRepository;

        public LocationsController(FriendFinderContext context, ILocationRepository locationRepository)
        {
            _context = context;
            _locationRepository = locationRepository;
        }

        //GET:      api/v1.0/locations
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Location>>> GetLocations()
        {
            try
            {
                var results = await _locationRepository.GetLocations();
                return Ok(results);
            }
            catch(Exception e)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Database Failure: {e.Message}");
            }
        }

        //GET:      api/v1.0/locations/n
        [HttpGet("{id}")]
        public async Task<ActionResult<Location>> GetLocation(int id)
        {
            try
            {
                var result = await _locationRepository.GetLocation(id);
                if(result == null)
                    return NotFound();
                
                return result;
            }
            catch(Exception e)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Database Failure: {e.Message}");
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<Location>>> GetLocationsByHobby(int id)
        {
            try
            {
                var results = await _locationRepository.GetLocationsByHobby(id);
                return Ok(results);
            }
            catch(Exception e)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Database Failure: {e.Message}");
            }
        }

        [HttpGet("{locationid, hobbyid}")]
        public async Task<ActionResult<Location>> GetLocationByHobby(int locationid, int hobbyid)
        {
            try
            {
                var result = await _locationRepository.GetLocationByHobby(locationid, hobbyid);
                if (result == null)
                    return NotFound();

                return result;
            }
            catch(Exception e)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Database Failure: {e.Message}");
            }
        }

        //POST:      api/v1.0/locations
        [HttpPost]
        public ActionResult<Location> PostLocation(Location location)
        {
            _context.Locations.Add(location);
            //Important to not forget to save the changes in context when using POST
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
            /* Above code line makes the changes that we want in our context,
            which means that when we save context it will save those changes and get rid of previous value */

            _context.SaveChanges();

            // Because of the changes has already been done, we do not need to return any content.
            // That´s why we return method NoContent. So we kinda return a NoContent object. => Returns a "204 NoContent" Status

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

