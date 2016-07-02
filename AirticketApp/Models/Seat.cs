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
        [Key]
        [Column(Order = 1)]
        public long FlightNumber { get; set; }
        [Key]
        [Column(Order = 2)]
        public char Letter { get; set; }
        [Key]
        [Column(Order = 3)]
        public DateTime Time { get; set; }
        public Flight Flight { get; set; }
    }
}