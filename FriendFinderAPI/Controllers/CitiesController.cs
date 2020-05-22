using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using FriendFinderAPI.Context;
using FriendFinderAPI.Models;
using FriendFinderAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FriendFinderAPI.Dtos;


namespace FriendFinderAPI.Controllers
{
    [Route("api/v1.0/[controller]")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        private readonly ICityRepository _cityRepository;
        private readonly IMapper _mapper;
        public CitiesController(ICityRepository cityRepository, IMapper mapper)
        {
            
            _cityRepository = cityRepository;
            _mapper = mapper;
        }

        //GET:      api/v1.0/cities
        [HttpGet(Name = "GetLocationsByID")]
        public async Task<ActionResult<IEnumerable<City>>> GetCities()
        {
            try
            {
                var results = await _cityRepository.GetCities();
                  for(int i = 0; i<results.Length;i++)
                  {
                      results[i].CityLinks = CreateLinksGetAllCity(results[i]);
                  }
                return Ok(results);
            }
            catch(Exception e)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Database Failure: {e.Message}");
            }
        }

        //GET:      api/v1.0/cities/n
        [HttpGet("{id}", Name = "GetCity")]
        public async Task<ActionResult<City>> GetCity(int id)
        {
            try
            {
                var result = await _cityRepository.GetCity(id);
                result.CityLinks = CreateLinksGetCity(result);
                if(result == null)
                    return NotFound();

                return Ok(result);
            }
            catch(Exception e)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Database Failure: {e.Message}");
            }
        }
        
        [HttpGet("hobby{id}", Name = "GetCitiesByHobby")]
        public async Task<ActionResult<IEnumerable<City>>> GetCitiesByHobby(int id)
        {
            try
            {
                var results = await _cityRepository.GetCitiesByHobby(id);
                return Ok(results);
            }
            catch(Exception e)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Database Failure: {e.Message}");
            }
        }

        //POST:      api/v1.0/cities
        [HttpPost (Name ="PostCity")]
        public async Task<ActionResult<CityDto>> PostCity(CityDto cityDto)
        {
            try
            {
                var mappedEntity = _mapper.Map<CityDto>(cityDto);
                _cityRepository.Add(mappedEntity);

                if(await _cityRepository.Save())
                    return Created($"api/v1.0/cities/{mappedEntity.CityID}", _mapper.Map<CityDto>(mappedEntity));
            }
            catch (Exception e)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError,$"Database Failure: {e.Message}");
            }
            return BadRequest();
        }
        

        //PUT:      api/v1.0/cities/n
        [HttpPut("{id}", Name ="PutCity")]
        public async Task<ActionResult<CityDto>> PutCity(int cityID, CityDto cityDto)
        {
            try
            {
                var oldCity = await _cityRepository.GetCity(cityID);
                if(oldCity == null)
                    return NotFound($"We could not find the city your looking for id: {cityID}");

                var newCity = _mapper.Map(cityDto, oldCity);
                _cityRepository.Update(newCity);

                if(await _cityRepository.Save())
                    return NoContent();
            }
            catch (Exception e)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError,$"Database Failure: {e.Message}");
            }
            return BadRequest();
        }

        //DELETE:       api/v1.0/cities/n
        [HttpDelete("{id}", Name = "DeleteCity")]
        public async Task<ActionResult> DeleteCity(int cityID)
        {
            try
            {
                var city = await _cityRepository.GetCity(cityID);
                if(city == null)
                    return NotFound($"Could not find the city with id: {cityID} ");

                _cityRepository.Delete(city);
                if(await _cityRepository.Save())
                    return NoContent();
            }
            catch (Exception e)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError,$"Database Failure: {e.Message}");
            }
            return BadRequest();
        }
         private IEnumerable<Link> CreateLinksGetAllCity(City city)
        {
            var links = new[]
            {
            new Link{
            Method = "GET",
            Rel = "self",
            Href = Url.Link("GetCity",new {id = city.CityID} ).ToLower()
            },
          
            };
            return links;
        }
         private IEnumerable<Link> CreateLinksGetCity(City city)
        {
            var links = new[]
            {
            new Link
            {
            Method = "GET",
            Rel = "self",
            Href = Url.Link("GetCity", new {id = city.CityID})
            },
            new Link
            {
            Method = "DELETE",
            Rel = "self",
            Href = Url.Link("DeleteCity", new {id = city.CityID})
            },
            new Link
            {
                Method = "PUT",
                Rel = "self",
                Href = Url.Link("PutCity", new {id = city.CityID})
            }
            };
            return links;
        }
        
    }
}