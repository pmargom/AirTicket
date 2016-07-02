using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AirticketApp.Common
{
    public static class CustomEnums
    {
        public enum PaymentStatus
        {
            Pending,
            Confirmed,
            Refused,
            Cancelled
        }

        public enum BoardingPassStatus
        {
            Pending,
            Used
        }

        public enum BookingStatus
        {
            Pending,
            Confirmed,
            Cancelled
        }

        public enum CreditCardType
        {
            Visa,
            MasterCard,
            AmericanExpress
        }

    }
}