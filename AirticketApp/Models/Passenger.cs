using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AirticketApp.Models
{
    public class Passenger
    {
        public int Id { get; set; }
        public string IdentificationOfPassenger { get; set; } // the passport, for example
        public Booking Booking { get; set; }
        public long BookingId { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Direction { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
}