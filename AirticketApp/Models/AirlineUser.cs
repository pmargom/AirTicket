using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AirticketApp.Models
{
    public class AirlineUser
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public ICollection<Flight> Flights { get; private set; }
        public ICollection<Booking> Bookings { get; private set; }

        public AirlineUser()
        {
            this.Flights = new HashSet<Flight>();
            this.Bookings = new HashSet<Booking>();
        }
    }
}