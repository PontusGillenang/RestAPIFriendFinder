using System;
using AutoMapper;
using FriendFinderAPI.Dtos;
using System.Threading.Tasks;
using FriendFinderAPI.Models;
using FriendFinderAPI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using Microsoft.AspNetCore.Routing;
using FriendFinderAPI.FilterAuthentication;

namespace FriendFinderAPI.Controllers
{
    [ApiKeyAuth]  
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
        [HttpGet(Name = "GetAllUsers")]
        public async Task<ActionResult<UserDto[]>> GetUsers(bool includeHobbies, bool includeEvents)
        {
            try
            {
                var results = await _userRepository.GetUsers(includeHobbies,includeEvents);
                if (results == null)
                {
                    return NotFound();
                }

                var mappedResults = _mapper.Map<UserDto[]>(results);

                for (int i = 0; i < mappedResults.Length; i++)
                {
                    mappedResults[i].Links = CreateLinksGetAllUsers(mappedResults[i]);
                }

                return Ok(mappedResults);
            }
            catch (Exception e)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Database Failure: {e.Message}");
            }
        }

        //GET:      api/v1.0/users/n
        [HttpGet("{userId}", Name = "GetUser")]
        public async Task<ActionResult<UserDto>> GetUser(int userId, bool includeHobbies, bool includeEvents)
        {
            try
            {
                var result = await _userRepository.GetUser(userId, includeHobbies, includeEvents);
                if (result == null)
                {
                    return NotFound();
                }

                var mappedResult = _mapper.Map<UserDto>(result);

                mappedResult.Links = CreateLinksGetAllUsers(mappedResult);

                return Ok(mappedResult);
            }
            catch (Exception e)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Database Failure: {e.Message}");
            }
        }

        //GET:      api/v1.0/users/hobby/n
        [HttpGet("hobby/{hobbyId}", Name = "GetUsersByHobby")]
        public async Task<ActionResult<UserDto[]>> GetUsersByHobby(int hobbyId)
        {
            try
            {
                var results = await _userRepository.GetUsersByHobby(hobbyId);
                if (results == null)
                {
                    return NotFound();
                }

                var mappedResults = _mapper.Map<UserDto[]>(results);

                for (int i = 0; i < mappedResults.Length; i++)
                {
                    mappedResults[i].Links = CreateLinksGetAllUsers(mappedResults[i]);
                }

                return Ok(mappedResults);
            }
            catch (Exception e)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Database Failure: {e.Message}");
            }
        }

        //GET:      api/v1.0/users/event/n
        [HttpGet("event/{eventId}", Name = "GetUsersByEvent")]
        public async Task<ActionResult<UserDto[]>> GetUsersByEvent(int eventId)
        {
            try
            {
                var results = await _userRepository.GetUsersByEvent(eventId);
                if (results == null)
                {
                    return NotFound();
                }

                var mappedResults = _mapper.Map<UserDto[]>(results);

                for (int i = 0; i < mappedResults.Length; i++)
                {
                    mappedResults[i].Links = CreateLinksGetAllUsers(mappedResults[i]);
                }

                return Ok(mappedResults);
            }
            catch (Exception e)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Database Failure: {e.Message}");
            }
        }

        //GET:      api/v1.0/users/city/n
        [HttpGet("city/{cityId}", Name = "GetUsersByCity")]
        public async Task<ActionResult<UserDto[]>> GetUsersByCity(int cityId, bool includeHobbies, bool includeEvents)
        {
            try
            {
                var results = await _userRepository.GetUsersByCity(cityId, includeHobbies, includeEvents);
                if (results == null)
                {
                    return NotFound();
                }

                var mappedResults = _mapper.Map<UserDto[]>(results);

                for (int i = 0; i < mappedResults.Length; i++)
                {
                    mappedResults[i].Links = CreateLinksGetAllUsers(mappedResults[i]);
                }

                return Ok(mappedResults);
            }
            catch (Exception e)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Database Failure: {e.Message}");
            }
        }

        //POST:     api/v1.0/users
        [HttpPost(Name = "PostUser")]
        public async Task<ActionResult<UserDto>> PostUser(UserDto userDto)
        {
            try
            {
                var mappedEntity = _mapper.Map<User>(userDto);
                _userRepository.Add(mappedEntity);
                if (await _userRepository.Save())
                {
                    return Created($"api/v1.0/users/{mappedEntity.UserId}", _mapper.Map<UserDto>(mappedEntity));
                }
            }
            catch (Exception e)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Database Failure: {e.Message}");
            }
            return BadRequest();
        }

        //PUT:      api/v1.0/users/n
        [HttpPut("{userId}", Name = "PutUser")]
        public async Task<ActionResult<UserDto>> PutUser(int userId, UserDto userDto, bool includeHobbies, bool includeEvents)
        {
            try
            {
                var oldUser = await _userRepository.GetUser(userId, includeHobbies, includeEvents);
                if (oldUser == null)
                {
                    return NotFound($"Can't find any user with that id: {userId}");
                }

                var newUser = _mapper.Map(userDto, oldUser);
                _userRepository.Update(newUser);
                if (await _userRepository.Save())
                {
                    return NoContent();
                }
            }
            catch (Exception e)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Database Failure: {e.Message}");
            }

            return BadRequest();
        }

        //DELETE        api/v1.0/users/n
        [HttpDelete("{userId}", Name = "DeleteUser")]
        public async Task<ActionResult> DeleteUser(int userId, bool includeHobbies, bool includeEvents)
        {
            try
            {
                var user = await _userRepository.GetUser(userId, includeHobbies, includeEvents);
                if (user == null)
                {
                    return NotFound($"We could not find a user with that id: {userId}");
                }

                _userRepository.Delete(user);
                
                if (await _userRepository.Save())
                {
                    return NoContent();
                }
            }
            catch (Exception e)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Database Failure: {e.Message}");
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
            }
            };
            return links;
        }
    }
}
