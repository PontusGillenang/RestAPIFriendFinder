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
    public class LocationsController : ControllerBase
    {
        private readonly ILocationRepository _locationRepository;
        private readonly IMapper _mapper;

        public LocationsController(ILocationRepository locationRepository, IMapper mapper)
        {
            _locationRepository = locationRepository;
            _mapper = mapper;
        }

        //GET:      api/v1.0/locations
        [HttpGet(Name ="GetLocations")]
        public async Task<ActionResult<IEnumerable<Location>>> GetLocations()
        {
            try
            {
                var results = await _locationRepository.GetLocations();
                for(int i = 0; i<results.Length;i++)
                {
                    results[i].LocationLinks = CreateLinksGetAllLocations(results[i]);
                };
                return Ok(results);
            }
            catch(Exception e)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Database Failure: {e.Message}");
            }
        }

        //GET:      api/v1.0/locations/n
        [HttpGet("{id}")]
        public async Task<ActionResult<Location>> GetLocation(int id)
        {
            try
            {
                var result = await _locationRepository.GetLocation(id);
                result.LocationLinks = CreateLinksGetLocation(result);
                if(result == null)
                    return NotFound();
                
                return result;
            }
            catch(Exception e)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Database Failure: {e.Message}");
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<Location>>> GetLocationsByHobby(int id)
        {
            try
            {
                var results = await _locationRepository.GetLocationsByHobby(id);
                return Ok(results);
            }
            catch(Exception e)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Database Failure: {e.Message}");
            }
        }

        [HttpGet("{locationid, hobbyid}")]
        public async Task<ActionResult<Location>> GetLocationByHobby(int locationid, int hobbyid)
        {
            try
            {
                var result = await _locationRepository.GetLocationByHobby(locationid, hobbyid);
                if (result == null)
                    return NotFound();

                return result;
            }
            catch(Exception e)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Database Failure: {e.Message}");
            }
        }

        //POST:      api/v1.0/locations
        [HttpPost (Name = "PostLocation")]
        public async Task<ActionResult<LocationDto>> PostLocation(LocationDto locationDto)
        {
            try
            {
                var mappedEntity = _mapper.Map<LocationDto>(locationDto);
                _locationRepository.Add(mappedEntity);

                if(await _locationRepository.Save())
                    return Created($"api/v1.0/cities/{mappedEntity.LocationID}", _mapper.Map<LocationDto>(mappedEntity));
            }
            catch (Exception e)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError,$"Database Failure: {e.Message}");
            }
            return BadRequest();
        }

        //PUT:      api/v1.0/locations/n
        [HttpPut("{id}", Name = "PutLocation")]
        public async Task<ActionResult<LocationDto>> PutLocation(int locationID, LocationDto locationDto)
        {
            try
            {
                var oldLocation = await _locationRepository.GetLocation(locationID);
                if(oldLocation == null)
                    return NotFound($"We could not find a location with that id: {locationID}");

                var newLocation = _mapper.Map(locationDto, oldLocation);
                _locationRepository.Update(newLocation);

                if(await _locationRepository.Save())
                    return NoContent();
            }
            catch (Exception e)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError,$"Database Failure: {e.Message}");
            }
            return BadRequest();
        }

        //DELETE:       api/v1.0/locations/n
        [HttpDelete("{id}", Name = "Deletelocation")]
        public async Task<ActionResult> DeleteLocation(int locationID)
        {
            try
            {
                var location = await _locationRepository.GetLocation(locationID);
                if(location == null)
                    return NotFound($"We could not find a location with that id: {locationID}");
                
                _locationRepository.Delete(location);
                if(await _locationRepository.Save())
                    return NoContent();
            }
            catch (Exception e)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError,$"Database Failure: {e.Message}");
            }
            return BadRequest();
        }

        private IEnumerable<Link> CreateLinksGetAllLocations(Location location)
        {
            var links = new[]
            {
            new Link{
            Method = "GET",
            Rel = "self",
            Href = Url.Link("GetLocation",new {id = location.LocationID} ).ToLower()
            },
          
            };
            return links;
        }
        private IEnumerable<Link> CreateLinksGetLocation(Location location)
        {
            var links = new[]
            {
            new Link
            {
            Method = "GET",
            Rel = "self",
            Href = Url.Link("Getlocation", new {id = location.LocationID})
            },
            new Link
            {
            Method = "DELETE",
            Rel = "self",
            Href = Url.Link("Deletelocation", new {id = location.LocationID})
            },
            new Link
            {
                Method = "PUT",
                Rel = "self",
                Href = Url.Link("PutLocation", new {id = location.LocationID})
            }
            };
            return links;
        }


        
    }
}

