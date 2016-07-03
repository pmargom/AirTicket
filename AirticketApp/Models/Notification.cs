using System;

namespace AirticketApp.Models
{
    public class Notification
    {
        public int Id { get; set; }
        public DateTime DateOfSent { get; set; }
        public string Content { get; set; }
        public PublicUser PublicUser { get; set; }
        public int PublicUserId { get; set; }

        public Notification()
        {
            this.DateOfSent = DateTime.Now; // to simplify, it assumes that when the notification is created is also sent.
        }
    }
}