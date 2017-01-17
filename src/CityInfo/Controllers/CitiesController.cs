using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CityInfo.Services;
using CityInfo.Models;

namespace CityInfo.Controllers
{
    [Route("api/cities")]
    public class CitiesController : Controller
    {
        private ICityInfoRepository _cityInfoRepository;

        public CitiesController(ICityInfoRepository cityInfoRepository)
        {
            _cityInfoRepository = cityInfoRepository;
        }

        [HttpGet()]
        public IActionResult GetCities()
        {
            //return Ok(new JsonResult(CitiesDataStore.Current.Cities));

            var cityEntities = _cityInfoRepository.GetCities();

            var results = new List<CityWithoutPointsOfInterestDto>();

            foreach (var cityEntity in cityEntities)
            {
                results.Add(new CityWithoutPointsOfInterestDto
                {

                    Id = cityEntity.Id,
                    Name = cityEntity.Name,
                    Description = cityEntity.Description
                });
            }

            return Ok(results);
        }

        [HttpGet("{id}")]
        public IActionResult GetCity(int id, bool includePointsOfInterest = false)
        {

            var city = _cityInfoRepository.GetCity(id, includePointsOfInterest);

            if (city == null)
            {
                return NotFound();
            }

            if (includePointsOfInterest)
            {
                var cityResult = new CityDto()
                {
                    Id = city.Id,
                    Name = city.Name,
                    Description = city.Description
                };

                foreach (var poi in city.PointsOfInterest)
                {
                    cityResult.PointsOfInterest.Add(

                        new PointOfInterestDto()
                        {

                            Id = city.Id,
                            Name = city.Name,
                            Description = city.Description
                        }

                    );
                }

                return Ok(cityResult);
            }

            var cityWithoutPointsOfInterestResult =
                new CityWithoutPointsOfInterestDto()
                {
                    Id = city.Id,
                    Name = city.Name,
                    Description = city.Description

                };

            return Ok(cityWithoutPointsOfInterestResult);


            // find city
            //var cityToReturn = new JsonResult(CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == id));

            //if (cityToReturn == null)
            //    return NotFound();

            //return Ok(cityToReturn);
        }
    }
}
