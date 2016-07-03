using System;
using System.Collections.Generic;
using AirticketApp.Common;

namespace AirticketApp.Models
{
    public class Booking
    {
        public long Id { get; set; }
        public string Reference { get; set; }
        public DateTime DateTime { get; set; }
        public decimal Amount { get; set; }
        public CustomEnums.BookingStatus Status { get; set; }
        public PublicUser PublicUser { get; set; }
        public int PublicUserId { get; set; }
        public AirlineUser AirlineUser { get; set; }
        public int AirlineUserId { get; set; }
        public ICollection<Passenger> Passengers { get; set; }
        public ICollection<BoardingPass> BoardingPasses { get; set; }
        public ICollection<Flight> Flights { get; set; }

        public Booking()
        {
            this.DateTime = DateTime.Now;
            this.Status = default(CustomEnums.BookingStatus);
            this.Passengers = new HashSet<Passenger>();
            this.BoardingPasses= new HashSet<BoardingPass>();
            this.Flights = new HashSet<Flight>();
        }
    }
}