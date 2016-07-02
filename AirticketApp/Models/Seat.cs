using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AirticketApp.Models
{
    public class Seat
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public char Letter { get; set; }
        public Flight Flight { get; set; }
        public int FlightId { get; set; }
        public string FlightNumber { get; set; }
    }
}