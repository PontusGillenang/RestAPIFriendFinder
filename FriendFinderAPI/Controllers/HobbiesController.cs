using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FriendFinderAPI.Context;
using FriendFinderAPI.Models;
using FriendFinderAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FriendFinderAPI.Dtos;
using AutoMapper;

namespace FriendFinderAPI.Controllers
{
    [Route("api/v1.0/[controller]")]
    [ApiController]
    public class HobbiesController : ControllerBase
    {
        private readonly IHobbyRepository _hobbyRepository;
        private readonly IMapper _mapper;

        public HobbiesController(IHobbyRepository hobbyRepository, IMapper mapper)
        {
            _hobbyRepository = hobbyRepository;
            _mapper = mapper;

        }

        //GET:      api/v1.0/hobbies
        [HttpGet(Name = "GetHobbies")]
        public async Task<ActionResult<IEnumerable<Hobby>>> GetHobbies()
        {
            try
            {
                 
                var results = await _hobbyRepository.GetHobbies();
                for(int i = 0; i<results.Length;i++)
                {
                    results[i].Links =CreateLinksGetAllHobbys(results[i]);
                }
                return Ok(results);
            }
            catch(Exception e)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Database Failure: {e.Message}");
            }
        }

        //GET:      api/v1.0/hobbies/n
        [HttpGet("{id}", Name ="GetHobby")]
        public async Task<ActionResult<Hobby>> GetHobby(int id)
        {
            try
            {
                var result = await _hobbyRepository.GetHobby(id);
                result.Links = CreateLinksGetAllHobbys(result);
                if(result == null)
                    return NotFound();

                return Ok(result);
            }
            catch(Exception e)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Database Failure: {e.Message}");
            }
        }

        [HttpGet("hobby/{hobbyid}/city/{cityid}", Name ="GetHobbyByCity")]
        public async Task<ActionResult<Hobby>> GetHobbyByCity(int hobbyid, int cityid)
        {
            try
            {
                var result = await _hobbyRepository.GetHobbyByCity(hobbyid, cityid);
                if (result == null)
                    return NotFound();

                result.Links = CreateLinksGetAllHobbys(result);
                return Ok(result);
            }
            catch(Exception e)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Database Failure: {e.Message}");
            }
        }
        [HttpGet("city/{id}", Name="GetHobbiesByCity")]
        public async Task<ActionResult<IEnumerable<Hobby>>> GetHobbiesByCity(int id)
        {
            try
            {
                var result = await _hobbyRepository.GetHobbiesByCity(id);
                 for(int i = 0; i<result.Length;i++)
                {
                    result[i].Links =CreateLinksGetAllHobbys(result[i]);
                }
                return Ok(result);
            }
            catch(Exception e)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Database Failure: {e.Message}");
            }
        }

        [HttpGet("user/{id}", Name ="GetHobbiesByUser")]
        public async Task<ActionResult<IEnumerable<Hobby>>> GetHobbiesByUser(int id)
        {
                try
                {
                        var result = await _hobbyRepository.GetHobbiesByUser(id);
                        for(int i = 0; i<result.Length;i++)
                        {
                        result[i].Links =CreateLinksGetAllHobbys(result[i]);
                        }
                        return Ok(result);
                }
                catch(Exception e)
                {
                    return this.StatusCode(StatusCodes.Status500InternalServerError, $"Database Failure: {e.Message}");
                }
        }

        //POST: api/v1.0/hobbies
        [HttpPost(Name = "PostHobby")]
        public async Task<ActionResult<HobbyDto>> PostHobby(HobbyDto hobbyDto)
        {
            try
            {
                var mappedEntity = _mapper.Map<HobbyDto>(hobbyDto);
                _hobbyRepository.Add(mappedEntity);

                if(await _hobbyRepository.Save())
                     return Created($"api/v1.0/cities/{mappedEntity.HobbyID}", _mapper.Map<HobbyDto>(mappedEntity));
                   
            }
            catch (Exception e)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError,$"Database Failure: {e.Message}");
            }
            return BadRequest();
        }

        //PUT:      api/v1.0/hobbies/n
        [HttpPut("{id}", Name= "PutHobby")]
        public async Task<ActionResult<HobbyDto>> PutHobby(int hobbyID, HobbyDto hobbyDto)
        {
            try
            {
                var oldHobby = await _hobbyRepository.GetHobby(hobbyID);
                if(oldHobby == null)
                    return NotFound($"There's no hobby with that id: {hobbyID}");

                var newHobby = _mapper.Map(hobbyDto, oldHobby);
                _hobbyRepository.Update(newHobby);

                if(await _hobbyRepository.Save())
                     return NoContent();

            }
            catch (Exception e)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError,$"Database Failure: {e.Message}");
            }
            return BadRequest();
        }

        //DELETE:       api/hobbies/n
        [HttpDelete("{id}", Name ="DeleteHobby")]
        public async Task<ActionResult> DeleteHobby(int hobbyID)
        {
            try
            {
                var hobby = await _hobbyRepository.GetHobby(hobbyID);
                if(hobby == null)
                    return NotFound($"Could not find any hobby with that id: {hobbyID}");

                _hobbyRepository.Delete(hobby);
                if(await _hobbyRepository.Save())
                    return NoContent();
            }
            catch (Exception e)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError,$"Database Failure: {e.Message}");
            }
            return BadRequest();
        }

        
         private IEnumerable<Link> CreateLinksGetAllHobbys(Hobby hobby)
        {
            var links = new[]
            {
            new Link
            {
            Method = "GET",
            Rel = "self",
            Href = Url.Link("GetHobby", new {id = hobby.HobbyID})
            },
            new Link
            {
            Method = "DELETE",
            Rel = "self",
            Href = Url.Link("DeleteHobby", new {id = hobby.HobbyID})
            },
            new Link
            {
                Method = "PUT",
                Rel = "self",
                Href = Url.Link("PutHobby", new {id = hobby.HobbyID})
            }
            };
            return links;
        }
    }
}