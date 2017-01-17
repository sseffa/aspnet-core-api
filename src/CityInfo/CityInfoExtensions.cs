using CityInfo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo
{
    public static class CityInfoExtensions
    {
        public static void EnsureSeedDataForContext(this CityInfoContext context)
        {
            if (context.Cities.Any())
            {
                return;
            }

            var cities = new List<City>() {

                new City()
                {

                    Name = "New York City",
                    Description = "Lorem ipsum sit amet",
                    PointsOfInterest = new List<PointOfInterest>()
                    {
                        new PointOfInterest()
                        {
                                Name = "Central Park",
                                Description = "Lorem ipsum sit amet",
                        },
                        new PointOfInterest()
                        {
                                Name = "Empire State Building",
                                Description = "Lorem ipsum sit amet",
                        }
                    }
                }
           };

            context.Cities.AddRange(cities);
            context.SaveChanges();
        }
    }
}
