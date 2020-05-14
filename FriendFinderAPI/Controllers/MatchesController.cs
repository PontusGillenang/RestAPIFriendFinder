using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FriendFinderAPI.Context;
using FriendFinderAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FriendFinderAPI.Controllers
{
    [Route("api/v1.0/[controller]")]
    [ApiController]
    public class MatchesController : ControllerBase
    {
        private readonly FriendFinderContext _context;
        private readonly IMatchRepository _matchRepository;

        public MatchesController(FriendFinderContext context, IMatchRepository matchRepository)
        {
            _context = context;
            _matchRepository = matchRepository;
        }

        //GET:      api/v1.0/matches
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Match>>> GetMatches()
        {
            try
            {
                var results = await _matchRepository.GetMatches();
                return Ok(results);
            }
            catch(Exception e)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Database Failure: {e.Message}");
            }
        }

        //GET:      api/v1.0/matches/n
        [HttpGet("{id}")]
        public async Task<ActionResult<Match>> GetMatch(int id)
        {
            try
            {
                var result = await _matchRepository.GetMatch(id);
                if(result == null)
                    return NotFound();
                
                return result;
            }
            catch(Exception e)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Database Failure: {e.Message}");
            }
        }

        //POST:     api/v1.0/matches
        [HttpPost]
        public ActionResult<Match> PostMatch(Match match)
        {
            _context.Matches.Add(match);
            //Important to not forget to save the changes in context when using POST
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
            /* Above code line makes the changes that we want in our context,
            which means that when we save context it will save those changes and get rid of previous value */
            _context.SaveChanges();

            // Because of the changes has already been done, we do not need to return any content.
            // That´s why we return method NoContent. So we kinda return a NoContent object. => Returns a "204 NoContent" Status

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