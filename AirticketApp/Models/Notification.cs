using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AirticketApp.Models
{
    public class Notification
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public string Content { get; set; }
        public PublicUser PublicUser { get; set; }
        public int PublicUserId { get; set; }
    }
}