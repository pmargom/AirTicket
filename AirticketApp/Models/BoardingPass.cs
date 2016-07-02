using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AirticketApp.Common;

namespace AirticketApp.Models
{
    public class BoardingPass
    {
        public long Id { get; set; }
        public Booking Booking { get; set; }
        public long BookingId { get; set; }
        public DateTime DateTime { get; set; }
        public CustomEnums.BoardingPassStatus Status { get; set; }
    }
}