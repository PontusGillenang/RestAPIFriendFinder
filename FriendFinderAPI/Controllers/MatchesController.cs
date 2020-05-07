using System.Collections.Generic;
using FriendFinderAPI.Context;
using FriendFinderAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FriendFinderAPI.Controllers
{
    [Route("api/v1.0/[controller]")]
    [ApiController]
    public class MatchesController : ControllerBase
    {
        private readonly FriendFinderContext _context;

        public MatchesController(FriendFinderContext context) => _context = context;

        //GET:      api/v1.0/matches
        [HttpGet]
        public ActionResult<IEnumerable<Match>> GetMatches() => _context.Matches;

        //GET:      api/v1.0/matches/n
        [HttpGet("{id}")]
        public ActionResult<Match> GetMatchByID(int id)
        {
            var match = _context.Matches.Find(id);
            if(match == null)
                return NotFound();
            
            return match;
        }

        //POST:     api/v1.0/matches
        [HttpPost]
        public ActionResult<Match> PostMatch(Match match)
        {
            _context.Matches.Add(match);
            _context.SaveChanges();

            return CreatedAtAction("GetMatch", new Match{MatchID= match.MatchID}, match);
        }

        //PUT:      api/v1.0/matches/n
        [HttpPut("{id}")]
        public ActionResult PutMatch(int id, Match match)
        {
            if(id != match.MatchID)
                return BadRequest();

            _context.Entry(match).State = EntityState.Modified;
            _context.SaveChanges();

            return NoContent();
        } 

        //DELETE:       api/v1.0/matches/n    
        [HttpDelete("{id}")]
        public ActionResult<Match> DeleteMatch(int id)
        {
            var match = _context.Matches.Find(id);
            if(match == null)
                return NotFound();

            _context.Matches.Remove(match);
            _context.SaveChanges();

            return match;
        }
    }
}