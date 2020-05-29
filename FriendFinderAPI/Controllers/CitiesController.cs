using AutoMapper;
using Castle.Core.Internal;
using FriendFinderAPI.Dtos;
using FriendFinderAPI.Models;
using FriendFinderAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;


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

        [HttpGet(Name = "GetCities")]
        public async Task<ActionResult<CityDto[]>> GetCities()
        {
            try
            {
                var results = await _cityRepository.GetCities();
                var mappedResults = _mapper.Map<CityDto[]>(results);

                if (mappedResults.IsNullOrEmpty())
                {
                    return NotFound();
                }

                for (int i = 0; i < mappedResults.Length; i++)
                {
                    mappedResults[i].Links = CreateLinksGetAllCities(mappedResults[i]);
                }

                return Ok(mappedResults);
            }
            catch (Exception exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Database Failure: {exception.Message}");
            }
        }

        [HttpGet("{cityId}", Name = "GetCity")]
        public async Task<ActionResult<CityDto>> GetCity(int cityId)
        {
            try
            {
                var result = await _cityRepository.GetCity(cityId);
                var mappedResult = _mapper.Map<CityDto>(result);

                if (mappedResult == null)
                {
                    return NotFound();
                }

                mappedResult.Links = CreateLinksGetAllCities(mappedResult);

                return Ok(mappedResult);
            }
            catch (Exception exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Database Failure: {exception.Message}");
            }
        }

        [HttpGet("searchhobby", Name = "GetCitiesByHobby")]
        public async Task<ActionResult<CityDto[]>> GetCitiesByHobby(string hobbyName)
        {
            try
            {
                var results = await _cityRepository.GetCitiesByHobby(hobbyName);
                var mappedResults = _mapper.Map<CityDto[]>(results);

                if (mappedResults.IsNullOrEmpty())
                {
                    return NotFound();
                }

                for (int i = 0; i < mappedResults.Length; i++)
                {
                    mappedResults[i].Links = CreateLinksGetAllCities(mappedResults[i]);
                }

                return Ok(mappedResults);
            }
            catch (Exception exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Database Failure: {exception.Message}");
            }
        }

        [HttpGet("searchlocation", Name = "GetCitiesWithLocation")]
        public async Task<ActionResult<CityDto[]>> GetCitiesWithLocation(string locationName)
        {
            try
            {
                var results = await _cityRepository.GetCitiesWithLocation(locationName);
                var mappedResults = _mapper.Map<CityDto[]>(results);

                if (mappedResults.IsNullOrEmpty())
                {
                    return NotFound();
                }

                for (int i = 0; i < mappedResults.Length; i++)
                {
                    mappedResults[i].Links = CreateLinksGetAllCities(mappedResults[i]);
                }

                return Ok(mappedResults);
            }
            catch (Exception exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Database Failure: {exception.Message}");
            }
        }

        [HttpPost(Name = "PostCity")]
        public async Task<ActionResult<CityDto>> PostCity(CityDto cityDto)
        {
            try
            {
                var mappedEntity = _mapper.Map<City>(cityDto);
                _cityRepository.Add(mappedEntity);

                if (await _cityRepository.Save())
                {
                    return Created($"/api/v1.0/cities/{mappedEntity.CityId}", _mapper.Map<CityDto>(mappedEntity));
                }
            }
            catch (Exception exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Database Failure: {exception.Message}");
            }
            return BadRequest();
        }

        [HttpPut("{cityId}", Name = "PutCity")]
        public async Task<ActionResult<CityDto>> PutCity(int cityId, CityDto cityDto)
        {
            try
            {
                var existingCity = await _cityRepository.GetCity(cityId);

                if (existingCity == null)
                {
                    return NotFound($"We could not find the city your looking for with id: {cityId}");
                }

                var newCity = _mapper.Map(cityDto, existingCity);
                _cityRepository.Update(newCity);

                if (await _cityRepository.Save())
                {
                    return NoContent();
                }
            }
            catch (Exception exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Database Failure: {exception.Message}");
            }
            return BadRequest();
        }

        [HttpDelete("{cityId}", Name = "DeleteCity")]
        public async Task<ActionResult> DeleteCity(int cityId)
        {
            try
            {
                var existingCity = await _cityRepository.GetCity(cityId);

                if (existingCity == null)
                {
                    return NotFound($"Could not find the city with id: {cityId}");
                }

                _cityRepository.Delete(existingCity);

                if (await _cityRepository.Save())
                {
                    return NoContent();
                }
            }
            catch (Exception exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Database Failure: {exception.Message}");
            }
            return BadRequest();
        }

        private IEnumerable<Link> CreateLinksGetAllCities(CityDto cityDto)
        {
            var links = new[]
            {
            new Link
            {
            Method = "GET",
            Rel = "self",
            Href = Url.Link("GetCity", new {cityId = cityDto.CityId})
            },
            new Link
            {
            Method = "DELETE",
            Rel = "self",
            Href = Url.Link("DeleteCity", new {cityId = cityDto.CityId})
            },
            new Link
            {
            Method = "PUT",
            Rel = "self",
            Href = Url.Link("PutCity", new {cityId = cityDto.CityId})
            }
            };
            return links;
        }
    }
}