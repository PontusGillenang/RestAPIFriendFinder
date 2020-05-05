using System.Collections.Generic;
using FriendFinderAPI.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FriendFinderAPI.Controllers
{
    public class UsersController : ControllerBase
    {
        private readonly UserContext _context;

        public UsersController(UserContext context) => _context = context;

        //GET:      api/users
        [HttpGet]
        public ActionResult<IEnumerable<User>> GetUsers()
        {
            return _context.Users;
        }

        //GET:      api/users/n
        [HttpGet("{id}")]
        public ActionResult<User> GetUserByID(int id)
        {
            var user = _context.Users.Find(id);
            if(user == null)
                return NotFound();

            return user;
        }

        //POST:     api/users
        [HttpPost]
        public ActionResult<User> PostUser(User user)
        {
            _context.Users.Add(user);
            //Important to dont forget that save the changes in context when using POST
            _context.SaveChanges();

            return CreatedAtAction("GetUser", new User{Id = user.Id}, user);
        }

        //PUT:      api/users/n
        [HttpPut("{id}")]
        public ActionResult PutUser(int id, User user)
        {
            if(id != user.Id)
                return BadRequest();
            
            _context.Entry(user).State = EntityState.Modified;
            // Above code line make the changes to we want, in our context,
            // Which means that when we Save context it will save those changes and get rid of previous value

            _context.SaveChanges();

            // Because of that the changes already been done, we do not need to return any content.
            // That´s why we return method NoContent. So we kinda returns a NoContent object. => Returns a "204 NoContent" Status

            return NoContent();
        }

        //DELETE        api/users/n
        [HttpDelete("{id}")]
        public ActionResult<User> DeleteUser(int id)
        {
            var user = _context.Users.Find(id);
            if(user == null)
                return NotFound();
            
            _context.Users.Remove(user);
            _context.SaveChanges();

            return user;
        }
        
    }
}