using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AirticketApp.Common
{
    public static class CustomEnums
    {
        public enum FLightStatus
        {
            Open,
            Close
        }

        public enum PaymentStatus
        {
            Pending,
            Confirmed,
            Refused,
            Cancelled
        }

        public enum BoardingPassStatus
        {
            Open,
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

        public enum PublicUserStatus
        {
            Active,
            Locked
        }
    }
}