using System.Collections.Generic;
using FriendFinderAPI.Context;
using FriendFinderAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FriendFinderAPI.Controllers
{
    [Route("api/v1.0/[controller]")]
    [ApiController]
    public class HobbiesController : ControllerBase
    {
        private readonly FriendFinderContext _context;

        public HobbiesController(FriendFinderContext context) => _context = context;

        //GET:      api/v1.0/hobbies
        [HttpGet]
        public ActionResult<IEnumerable<Hobby>> GetHobbies() => _context.Hobbies;

        //GET:      api/v1.0/hobbies/n
        [HttpGet("{id}")]
        public ActionResult<Hobby> GetHobbyByID(int id)
        {
            var hobby = _context.Hobbies.Find(id);
            if(hobby == null)
                return NotFound();
            
            return hobby;
        }

        //POST: api/v1.0/hobbies
        [HttpPost]
        public ActionResult<Hobby> PostHobby(Hobby hobby)
        {
            _context.Hobbies.Add(Hobby);
            //Important to dont forget that save the changes in context when using POST
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
            // Above code line make the changes to we want, in our context,
            // Which means that when we Save context it will save those changes and get rid of previous value

            _context.SaveChanges();
            // Because of that the changes already been done, we do not need to return any content.
            // That´s why we return method NoContent. So we kinda returns a NoContent object. => Returns a "204 NoContent" Status

            return NoContent();
        }

        //DELETE:       api/hobbies/n
        [HttpDelete("{id}")]
        public ActionResult<Hobby> DeleteHobby(int id)
        {
            var hobby = _context.Hobby.Find(id);
            if(hobby == null)
                return NotFound();
            
            _context.Hobbies.Remove(hobby);
            _context.SaveChanges();

            return hobby;
        }
    }
}