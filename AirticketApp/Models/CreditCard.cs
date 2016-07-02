using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AirticketApp.Common;

namespace AirticketApp.Models
{
    public class CreditCard
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }
        public CustomEnums.CreditCardType Type { get; set; }
        public string ExpirationMonth { get; set; }
        public string ExpirationYear { get; set; }
        public PublicUser PublicUser { get; set; }
        public int PublicUserId { get; set; }
        public ICollection<Payment> Payments { get; private set; }

        public CreditCard()
        {
            this.Payments = new HashSet<Payment>();
        }
    }
}