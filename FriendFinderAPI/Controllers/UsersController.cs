using FriendFinderAPI.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FriendFinderAPI.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System;
using FriendFinderAPI.Services;
using System.Collections.Generic;
using FriendFinderAPI.Dtos;
using AutoMapper;
using Microsoft.AspNetCore.Routing;

namespace FriendFinderAPI.Controllers
{
    [Route("api/v1.0/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        private LinkGenerator _linkGenerator;
        public UsersController(IUserRepository userRepository, IMapper mapper, LinkGenerator linkGenerator) 
        {
            _userRepository = userRepository; 
            _mapper = mapper;
            _linkGenerator = linkGenerator;
        }    

        //GET:      api/v1.0/users
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            try
            {
                var results = await _userRepository.GetUsers();
                return Ok(results);
            }
            catch(Exception e)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Database Failure: {e.Message}");
            }
        }

        //GET:      api/v1.0/users/n
        [HttpGet("{id}", Name ="GetUser")]
        public async Task<ActionResult<User>> GetUser(int id)
        {
            try
            {
                var result = await _userRepository.GetUser(id);
                result.UserLinks = CreateLinksGetUser(result);
                if(result == null)
                    return NotFound();

                return Ok(result);
            }
            catch(Exception e)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Database Failure: {e.Message}");
            }
        }
        
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<User>>> GetUsersByHobby(int id)
        {
            try
            {
                var results = await _userRepository.GetUsersByHobby(id);
                return Ok(results);
            }
            catch(Exception e)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Database Failure: {e.Message}");
            }
        }
       
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<User>>> GetUserTeacherByHobby(int id)
        {
            try
            {
                var results = await _userRepository.GetUserTeacherByHobby(id);
                return Ok(results);
            }
            catch(Exception e)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Database Failure: {e.Message}");
            }
        }

        //POST:     api/v1.0/users
        [HttpPost]
        public async Task<ActionResult<UserDto>> PostUser(UserDto userDto)
        {
            try
            {
                var mappedEntity = _mapper.Map<User>(userDto);
                _userRepository.Add(mappedEntity);
                if(await _userRepository.Save())
                    return Created($"api/v1.0/users/{mappedEntity.UserID}", _mapper.Map<UserDto>(mappedEntity));
            }
            catch (Exception e)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError,$"Database Failure: {e.Message}");
            }
            return BadRequest();
        }

        //PUT:      api/v1.0/users/n
        [HttpPut("{id}")]
        public async Task<ActionResult<UserDto>> PutUser(UserDto userDto)
        {
            try
            {
                var mappedEntity = _mapper.Map<User>(userDto);
                _userRepository.Update(mappedEntity);
                
                if(await _userRepository.Save())
                    return Created($"api/v1.0/users/{mappedEntity.UserID}", _mapper.Map<UserDto>(mappedEntity) );
            }
            catch (Exception e)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError,$"Database Failure: {e.Message}");
            }

            return BadRequest();
        }

        //DELETE        api/v1.0/users/n
        [HttpDelete("{id}", Name = "DeleteUser")]
        public async Task<ActionResult<UserDto>> DeleteUser(UserDto userDto)
        {
            try
            {
                var mappedEntity = _mapper.Map<User>(userDto);
                _userRepository.Delete(mappedEntity);
                
                if(await _userRepository.Save())
                return Created($"api/v1.0/users/{mappedEntity.UserID}", _mapper.Map<UserDto>(mappedEntity) );
            }
            catch (Exception e)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError,$"Database Failure: {e.Message}");
            }

            return BadRequest();
        }
        private IEnumerable<Link> CreateLinksGetUser(User user)
        {
            var links = new[]
            {
            new Link{
            Method = "GET",
            Rel = "self",
            Href = Url.Link("GetUser", new {id = user.UserID})
            },
            new Link{
            Method = "DELETE",
            Rel = "self",
            Href = Url.Link("DeleteUser", new {id = user.UserID})
            }
            };
            return links;
        }
    }
}