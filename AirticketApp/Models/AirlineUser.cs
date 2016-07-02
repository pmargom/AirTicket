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
        [Required]
        [Key]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
    }
}