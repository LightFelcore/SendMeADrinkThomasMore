﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SendMeADrink_Official.Database
{
    public class Bar
    {
        public string Id { get; set; }
        public string BarName { get; set; }
        public string Address { get; set; }
        public string Postalcode { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public double Distance { get; set; }
    }
}