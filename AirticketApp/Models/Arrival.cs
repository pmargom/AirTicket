using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AirticketApp.Models
{
    public class Arrival
    {
        [Key]
        [Column(Order = 1)]
        public string FlightNumber { get; set; }
        [Key]
        [Column(Order = 2)]
        public DateTime Date { get; set; }
        [Key]
        [Column(Order = 3)]
        public DateTime Time { get; set; }
        public Airport Airport { get; set; }
        public int AirPortId { get; set; }
        public Flight Flight { get; set; }
    }
}