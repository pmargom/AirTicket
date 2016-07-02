using System.Data.Entity.ModelConfiguration;
using AirticketApp.Models;

namespace AirticketApp.EntityTypeConfigurations
{
    public class PassengerConfiguration: EntityTypeConfiguration<Passenger>
    {
        public PassengerConfiguration()
        {
            Property(p => p.IdentificationOfPassenger)
                .IsRequired()
                .HasMaxLength(15)
                .HasUniqueIndexAnnotation("IX_Passengers_PassenderId_Booking_Id", 0);

            Property(p => p.BookingId)
                .IsRequired()
                .HasUniqueIndexAnnotation("IX_Passengers_PassenderId_Booking_Id", 1);

            Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(50);

            Property(p => p.Phone)
                .IsRequired()
                .HasMaxLength(15);

            Property(p => p.Direction)
                .IsRequired()
                .HasMaxLength(150);

            Property(p => p.ZipCode)
                .IsRequired()
                .HasMaxLength(6);

            Property(p => p.City)
                .IsRequired()
                .HasMaxLength(75);

            Property(p => p.Country)
                .IsRequired()
                .HasMaxLength(30);

        }

    }
}
