﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CityInfo.API.Models;

namespace CityInfo.API
{
    public class CitiesDataStore
    {
        public static CitiesDataStore Current { get; } = new CitiesDataStore();
        public List<CityDto> Cities { get; set; }

        public CitiesDataStore()
        {
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id = 1,
                    Name = "New York City",
                    Description = "The Big Apple."
                },
                new CityDto()
                {
                    Id = 2,
                    Name = "Melbourne",
                    Description = "The City of Coffee."
                },
                new CityDto()
                {
                    Id = 3,
                    Name = "Paris",
                    Description = "Big Metal Tower."
                }
            };
        }
    }
}
