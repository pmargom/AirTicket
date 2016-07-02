using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AirticketApp.Models
{
    public class Flight
    {
        [Key]
        public string Number { get; set; }
        public Airline Airline { get; set; }
        public int AirlineId { get; set; }
        public int UpdatedByUserId { get; set; }
    }
}