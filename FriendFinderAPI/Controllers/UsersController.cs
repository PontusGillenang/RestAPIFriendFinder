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
using System.Linq;

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
        [HttpGet(Name= "GetAllUsers")]
        public async Task<ActionResult<UserDto[]>> GetUsers()
        {
            try
            {
                var results = await _userRepository.GetUsers();
                var mappedResults = _mapper.Map<UserDto[]>(results);
                for(int i =0; i< mappedResults.Length; i++)
                {
                     mappedResults[i].Links = CreateLinksGetAllUsers(mappedResults[i]);
                }
                return Ok(mappedResults);
            }
            catch(Exception e)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Database Failure: {e.Message}");
            }
        }

        //GET:      api/v1.0/user/n
        [HttpGet("{userId}", Name ="GetUser")]
        public async Task<ActionResult<UserDto>> GetUser(int userId)
        {
            try
            {
                var result = await _userRepository.GetUser(userId);
                if(result == null)
                    return NotFound();

                var mappedResult = _mapper.Map<UserDto>(result);
                mappedResult.Links = CreateLinksGetAllUsers(mappedResult);
                return Ok(mappedResult);
            }
            catch(Exception e)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Database Failure: {e.Message}");
            }
        }
        
        [HttpGet("hobby/{hobbyId}", Name ="GetUserByHobby")]
        public async Task<ActionResult<UserDto[]>> GetUsersByHobby(int hobbyId)
        {
            try
            {
                var results = await _userRepository.GetUsersByHobby(hobbyId);
                var mappedResults = _mapper.Map<UserDto[]>(results);
                for(int i =0; i< mappedResults.Length; i++)
                {
                    mappedResults[i].Links = CreateLinksGetAllUsers(mappedResults[i]);
                }
                return Ok(mappedResults);            
                }
            catch(Exception e)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Database Failure: {e.Message}");
            }
        }

        //POST:     api/v1.0/users
        [HttpPost (Name= "PostUser")]
        public async Task<ActionResult<UserDto>> PostUser(UserDto userDto)
        {
            try
            {
                var mappedEntity = _mapper.Map<User>(userDto);
                _userRepository.Add(mappedEntity);
                if(await _userRepository.Save())
                    return Created($"api/v1.0/users/{mappedEntity.UserId}", _mapper.Map<UserDto>(mappedEntity));
            }
            catch (Exception e)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError,$"Database Failure: {e.Message}");
            }
            return BadRequest();
        }

        //PUT:      api/v1.0/users/n
        [HttpPut("{userId}", Name= "PutUser")]
        public async Task<ActionResult<UserDto>> PutUser(int userId, UserDto userDto)
        {
            try
            {
                var oldUser = await _userRepository.GetUser(userId);
                if(oldUser == null)
                    return NotFound($"Can't find any user with that id: {userId}");

                var newUser = _mapper.Map(userDto, oldUser);
                _userRepository.Update(newUser);
                if(await _userRepository.Save())
                    return NoContent();
            }
            catch (Exception e)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError,$"Database Failure: {e.Message}");
            }

            return BadRequest();
        }

        //DELETE        api/v1.0/users/n
        [HttpDelete("{userId}", Name= "DeleteUser")]
        public async Task<ActionResult> DeleteUser(int userId)
        {
            try
            {
                var user = await _userRepository.GetUser(userId);
                if(user == null)
                    return NotFound($"We could not find a user with that id: {userId}");
                
                _userRepository.Delete(user);
                if(await _userRepository.Save())
                    return NoContent();
            }
            catch (Exception e)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError,$"Database Failure: {e.Message}");
            }

            return BadRequest();
        }
        private IEnumerable<Link> CreateLinksGetAllUsers(UserDto user)
        {
            var links = new[]
            {
            new Link
            {
            Method = "GET",
            Rel = "self",
            Href = Url.Link("GetUser", new {userId = user.UserId})
            },
            new Link
            {
            Method = "DELETE",
            Rel = "self",
            Href = Url.Link("DeleteUser", new {userId = user.UserId})
            },
            new Link
            {
            Method = "Put",
            Rel = "self",
            Href = Url.Link("PutUser", new {userId = user.UserId})
            },
            //   new Link
            // {
            // Method = "GET",
            // Rel ="CityUser",
            // Href = Url.Link("GetCity", new {userId = user.UserCityID})           
            // }, 
            // new Link
            // {
            //     Method = "GET",
            //     Rel ="UserHobbies",
            //     Href = Url.Link("GetHobbiesByUser", new {userId = user.UserId}).ToLower()           
            // }
            };
            return links;
        }
       
        }
    }
