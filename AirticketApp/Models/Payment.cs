using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using AirticketApp.Common;

namespace AirticketApp.Models
{
    public class Payment
    {
        public long Id { get; set; }
        public Booking Booking { get; set; }
        public long BookingId { get; set; }
        public string Reference { get; set; }
        public CustomEnums.PaymentStatus Status { get; set; }
        public ICollection<CreditCard> CreditCards { get; private set; }

        public Payment()
        {
            this.Status = default(CustomEnums.PaymentStatus);
            this.CreditCards = new HashSet<CreditCard>();
        }

    }
}