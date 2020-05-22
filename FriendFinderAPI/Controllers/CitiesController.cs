using System;
using AutoMapper;
using FriendFinderAPI.Dtos;
using FriendFinderAPI.Models;
using System.Threading.Tasks;
using FriendFinderAPI.Context;
using Microsoft.AspNetCore.Mvc;
using FriendFinderAPI.Services;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;


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
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CityDto>>> GetCities()
        {
            try
            {
                var results = await _cityRepository.GetCities();
                var mappedResults = _mapper.Map<IEnumerable<CityDto>>(results);
                return Ok(mappedResults);
            }
            catch(Exception e)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Database Failure: {e.Message}");
            }
        }

        //GET:      api/v1.0/cities/n
        [HttpGet("{id}")]
        public async Task<ActionResult<CityDto>> GetCity(int id)
        {
            try
            {
                var result = await _cityRepository.GetCity(id);

                if(result == null)
                {
                    return NotFound();
                }

                var mappedResults = _mapper.Map<CityDto>(result);
                return Ok(mappedResults);
            }
            catch(Exception e)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Database Failure: {e.Message}");
            }
        }
        
        [HttpGet("hobby")]
        public async Task<ActionResult<IEnumerable<CityDto>>> GetCitiesByHobby(int id)
        {
            try
            {
                var results = await _cityRepository.GetCitiesByHobby(id);
                var mappedResults = _mapper.Map<IEnumerable<CityDto>>(results);
                return Ok(results);
            }
            catch(Exception e)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Database Failure: {e.Message}");
            }
        }

        //POST:      api/v1.0/cities
        [HttpPost]
        public async Task<ActionResult<CityDto>> PostCity(CityDto cityDto)
        {
            try
            {
                var mappedEntity = _mapper.Map<City>(cityDto);

                _cityRepository.Add(mappedEntity);
                if(await _cityRepository.Save())
                {
                    return Created($"api/v1.0/cities/{mappedEntity.CityID}", _mapper.Map<CityDto>(mappedEntity));
                }
            }
            catch (Exception e)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError,$"Database Failure: {e.Message}");
            }
            return BadRequest();
        }
        

        //PUT:      api/v1.0/cities/n
        [HttpPut("{cityId}")]
        public async Task<ActionResult<CityDto>> PutCity(int cityId, CityDto cityDto)
        {
            try
            {
                var oldCity = await _cityRepository.GetCity(cityId);
                if(oldCity == null)
                    return NotFound($"We could not find the city your looking for id: {cityId}");

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
        [HttpDelete("{cityId}")]
        public async Task<ActionResult> DeleteCity(int cityId)
        {
            try
            {
                var city = await _cityRepository.GetCity(cityId);
                if(city == null)
                {
                    return NotFound($"Could not find the city with id: {cityId} ");
                }

                _cityRepository.Delete(city);
                if(await _cityRepository.Save())
                {
                    return NoContent();
                }
            }
            catch (Exception e)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError,$"Database Failure: {e.Message}");
            }
            return BadRequest();
        }
    }
}