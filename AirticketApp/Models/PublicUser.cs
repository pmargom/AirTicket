using System.Collections.Generic;
using AirticketApp.Common;

namespace AirticketApp.Models
{
    public class PublicUser
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public CustomEnums.PublicUserStatus Status { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Direction { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public ICollection<Booking> Bookings { get; set; }
        public ICollection<CreditCard> CreditCards { get; set; }
        public ICollection<Notification> Notifications { get; set; }

        public PublicUser()
        {
            this.Status = default(CustomEnums.PublicUserStatus);
            this.Bookings = new HashSet<Booking>();
            this.CreditCards = new HashSet<CreditCard>();
            this.Notifications = new HashSet<Notification>();
        }
    }
}