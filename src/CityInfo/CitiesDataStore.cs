using CityInfo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo
{
    public class CitiesDataStore
    {
        public static CitiesDataStore Current { get; } = new CitiesDataStore();
        public List<CityDto> Cities { get; set; }

        public CitiesDataStore()
        {

            Cities = new List<CityDto>() {

                new CityDto()
                {

                    Id = 1,
                    Name = "New York City",
                    Description = "Lorem ipsum sit amet",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                                Id = 1,
                                Name = "Central Park",
                                Description = "Lorem ipsum sit amet",
                        },
                        new PointOfInterestDto()
                        {
                                Id = 1,
                                Name = "Empire State Building",
                                Description = "Lorem ipsum sit amet",
                        }
                    }
                },
                 new CityDto()
                {

                    Id = 12,
                    Name = "Ankara",
                    Description = "Lorem ipsum sit amet"
                },
                  new CityDto()
                {

                    Id = 3,
                    Name = "Paris",
                    Description = "Lorem ipsum sit amet"
                }
           };
        }
    }
}
