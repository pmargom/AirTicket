using System;
using AirticketApp.Common;

namespace AirticketApp.Models
{
    public class BoardingPass
    {
        public long Id { get; set; }
        public Booking Booking { get; set; }
        public long BookingId { get; set; }
        public DateTime DateOfCreation { get; set; }
        public CustomEnums.BoardingPassStatus Status { get; set; }

        public BoardingPass()
        {
            this.Status = default(CustomEnums.BoardingPassStatus);
            this.DateOfCreation = DateTime.Now;
        }
    }
}