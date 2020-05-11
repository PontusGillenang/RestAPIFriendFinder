using System.Collections.Generic;
using FriendFinderAPI.Context;
using FriendFinderAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FriendFinderAPI.Controllers
{
    [Route("api/v1.0/[controller]")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        private readonly FriendFinderContext _context;

        public CitiesController(FriendFinderContext context) => _context = context;

        //GET:      api/v1.0/cities
        [HttpGet]
        public ActionResult<IEnumerable<City>> GetCities() => _context.Cities;

        //GET:      api/v1.0/cities/n
        [HttpGet("{id}")]
        public ActionResult<City> GetCityByID(int id)
        {
            var city = _context.Cities.Find(id);
            if(city == null)
                return NotFound();
            
            return city;
        }

        //POST:      api/v1.0/cities
        [HttpPost]
        public ActionResult<City> PostCity(City city)
        {
            _context.Cities.Add(city);
            //Important to not forget to save the changes in context when using POST
            _context.SaveChanges();

            return CreatedAtAction("GetCity", new City{CityID = city.CityID}, city);
        }

        //PUT:      api/v1.0/cities/n
        [HttpPut("{id}")]
        public ActionResult PutCity(int id, City city)
        {
            if(id != city.CityID)
                return BadRequest();
            
            _context.Entry(city).State = EntityState.Modified;
            /* Above code line makes the changes that we want in our context,
            which means that when we save context it will save those changes and get rid of previous value */

            _context.SaveChanges();

            // Because of the changes has already been done, we do not need to return any content.
            // That´s why we return method NoContent. So we kinda return a NoContent object. => Returns a "204 NoContent" Status 

            return NoContent();
        }

        //DELETE:       api/v1.0/cities/n
        [HttpDelete("{id}")]
        public ActionResult<City> DeleteCity(int id)
        {
            var city = _context.Cities.Find(id);
            if(city == null)
                return NotFound();
            
            _context.Cities.Remove(city);
            _context.SaveChanges();

            return city;
        }
        
    }
}