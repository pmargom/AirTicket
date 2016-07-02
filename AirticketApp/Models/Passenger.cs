using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AirticketApp.Models
{
    public class Passenger
    {
        public long Id { get; set; }
        public Booking Booking { get; set; }
        public long BookingId { get; set; }
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        [Required]
        [MaxLength(15)]
        public string Phone { get; set; }
        [Required]
        [MaxLength(150)]
        public string Direction { get; set; }
        [Required]
        [MaxLength(6)]
        public string ZipCode { get; set; }
        [Required]
        [MaxLength(75)]
        public string City { get; set; }
        [Required]
        [MaxLength(30)]
        public string Country { get; set; }
    }
}