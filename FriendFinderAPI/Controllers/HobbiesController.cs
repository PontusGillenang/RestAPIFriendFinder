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
    public class HobbiesController : ControllerBase
    {
        private readonly FriendFinderContext _context;
        private readonly IHobbyRepository _hobbyRepository;

        public HobbiesController(FriendFinderContext context, IHobbyRepository hobbyRepository)
        {
            _context = context;
            _hobbyRepository = hobbyRepository;
        }

        //GET:      api/v1.0/hobbies
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Hobby>>> GetHobbies()
        {
            try
            {
                var results = await _hobbyRepository.GetHobbies();
                return Ok(results);
            }
            catch(Exception e)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Database Failure: {e.Message}");
            }
        }

        //GET:      api/v1.0/hobbies/n
        [HttpGet("{id}")]
        public async Task<ActionResult<Hobby>> GetHobby(int id)
        {
            try
            {
                var result = await _hobbyRepository.GetHobby(id);
                if(result == null)
                    return NotFound();

                return Ok(result);
            }
            catch(Exception e)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Database Failure: {e.Message}");
            }
        }

        //POST: api/v1.0/hobbies
        [HttpPost]
        public ActionResult<Hobby> PostHobby(Hobby hobby)
        {
            _context.Hobbies.Add(hobby);
            //Important to not forget to save the changes in context when using POST
            _context.SaveChanges();

            return CreatedAtAction("GetHobby", new Hobby{HobbyID = hobby.HobbyID}, hobby);
        }

        //PUT:      api/v1.0/hobbies/n
        [HttpPut("{id}")]
        public ActionResult PutHobby(int id, Hobby hobby)
        {
            if(id !=  hobby.HobbyID)
                return BadRequest();
            
            _context.Entry(hobby).State = EntityState.Modified;
            /* Above code line makes the changes that we want in our context,
            which means that when we save context it will save those changes and get rid of previous value */

            _context.SaveChanges();
            // Because of the changes has already been done, we do not need to return any content.
            // That´s why we return method NoContent. So we kinda return a NoContent object. => Returns a "204 NoContent" Status

            return NoContent();
        }

        //DELETE:       api/hobbies/n
        [HttpDelete("{id}")]
        public ActionResult<Hobby> DeleteHobby(int id)
        {
            var hobby = _context.Hobbies.Find(id);
            if(hobby == null)
                return NotFound();
            
            _context.Hobbies.Remove(hobby);
            _context.SaveChanges();

            return hobby;
        }
    }
}