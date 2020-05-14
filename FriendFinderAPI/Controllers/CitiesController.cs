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
    public class CitiesController : ControllerBase
    {
        private readonly FriendFinderContext _context;
        private readonly ICityRepository _cityRepository;

        public CitiesController(FriendFinderContext context, ICityRepository cityRepository)
        {
            _context = context;
            _cityRepository = cityRepository;
        }

        //GET:      api/v1.0/cities
        [HttpGet]
        public async Task<ActionResult<IEnumerable<City>>> GetCities()
        {
            try
            {
                var results = await _cityRepository.GetCities();
                return Ok(results);
            }
            catch(Exception e)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Database Failure: {e.Message}");
            }
        }

        //GET:      api/v1.0/cities/n
        [HttpGet("{id}")]
        public async Task<ActionResult<City>> GetCity(int id)
        {
            try
            {
                var result = await _cityRepository.GetCity(id);
                if(result == null)
                    return NotFound();

                return Ok(result);
            }
            catch(Exception e)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Database Failure: {e.Message}");
            }
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