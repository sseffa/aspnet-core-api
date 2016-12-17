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
                    Desription = "Lorem ipsum sit amet"
                },
                 new CityDto()
                {

                    Id = 12,
                    Name = "Ankara",
                    Desription = "Lorem ipsum sit amet"
                },
                  new CityDto()
                {

                    Id = 3,
                    Name = "Paris",
                    Desription = "Lorem ipsum sit amet"
                }
           };
        }
    }
}
