﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AirticketApp.Models
{
    public class Arrival
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public Airport Airport { get; set; }
        public int AirPortId { get; set; }
        public Flight Flight { get; set; }
        public int FlightId { get; set; }
    }
}