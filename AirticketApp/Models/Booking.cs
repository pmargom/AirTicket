using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using AirticketApp.Common;

namespace AirticketApp.Models
{
    public class Booking
    {
        public long Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Reference { get; set; }
        [Required]
        public DateTime DateTime { get; set; }
        [Required]
        public decimal Amount { get; set; }
        [Required]
        public CustomEnums.BookingStatus Status { get; set; }
        public PublicUser PublicUser { get; set; }
        public int PublicUserId { get; set; }
        public int UpdatedByUserId { get; set; }
    }
}