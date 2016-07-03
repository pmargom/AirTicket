using System.Collections.Generic;
using AirticketApp.Common;

namespace AirticketApp.Models
{
    public class Flight
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public Airline Airline { get; set; }
        public int AirlineId { get; set; }
        public AirlineUser AirlineUser { get; set; }
        public int AirlineUserId { get; set; }
        public CustomEnums.FLightStatus Status { get; set; }
        public ICollection<Seat> Seats { get; set; }
        public ICollection<Booking> Bookings { get; set; }

        public Flight()
        {
            this.Status = default(CustomEnums.FLightStatus);
            this.Seats = new HashSet<Seat>();
            this.Bookings = new HashSet<Booking>();
        }
    }
}