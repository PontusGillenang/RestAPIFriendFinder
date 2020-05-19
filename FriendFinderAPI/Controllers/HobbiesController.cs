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
        private readonly IHobbyRepository _hobbyRepository;
        private readonly IMapper _mapper;

        public HobbiesController(IHobbyRepository hobbyRepository, IMapper mapper)
        {
            _hobbyRepository = hobbyRepository;
            _mapper = mapper;

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

        [HttpGet("hobbyid, cityid")]
        public async Task<ActionResult<Hobby>> GetHobbyByCity(int hobbyid, int cityid)
        {
            try
            {
                var result = await _hobbyRepository.GetHobbyByCity(hobbyid, cityid);
                if (result == null)
                    return NotFound();

                return Ok(result);
            }
            catch(Exception e)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Database Failure: {e.Message}");
            }
        }
        [HttpGet("id")]
        public async Task<ActionResult<IEnumerable<Hobby>>> GetHobbiesByCity(int id)
        {
            try
            {
                var result = await _hobbyRepository.GetHobbiesByCity(id);
                return Ok(result);
            }
            catch(Exception e)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Database Failure: {e.Message}");
            }
        }

        //POST: api/v1.0/hobbies
        [HttpPost]
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
        [HttpPut("{id}")]
        public async Task<ActionResult<HobbyDto>> PutHobby(HobbyDto hobbyDto)
        {
            try
            {
                var mappedEntity = _mapper.Map<HobbyDto>(hobbyDto);
                _hobbyRepository.Update(mappedEntity);

                if(await _hobbyRepository.Save())
                     return Created($"api/v1.0/cities/{mappedEntity.HobbyID}", _mapper.Map<HobbyDto>(mappedEntity));

            }
            catch (Exception e)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError,$"Database Failure: {e.Message}");
            }
            return BadRequest();
        }

        //DELETE:       api/hobbies/n
        [HttpDelete("{id}")]
        public async Task<ActionResult<HobbyDto>> DeleteHobby(HobbyDto hobbyDto)
        {
            try
            {
                var mappedEntity = _mapper.Map<HobbyDto>(hobbyDto);
                _hobbyRepository.Delete(mappedEntity);

                if(await _hobbyRepository.Save())
                     return Created($"api/v1.0/cities/{mappedEntity.HobbyID}", _mapper.Map<HobbyDto>(mappedEntity));

            }
            catch (Exception e)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError,$"Database Failure: {e.Message}");
            }
            return BadRequest();
        }
    }
}