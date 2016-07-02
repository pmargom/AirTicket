using System.Data.Entity.ModelConfiguration;
using AirticketApp.Models;

namespace AirticketApp.EntityTypeConfigurations
{
    public class SeatConfiguration: EntityTypeConfiguration<Seat>
    {
        public SeatConfiguration()
        {
            Property(p => p.FlightNumber)
                .IsRequired()
                .HasMaxLength(20)
                .HasUniqueIndexAnnotation("IX_Flight_Seat_Flight_Number", 0);

            Property(p => p.Number)
                .IsRequired()
                .HasUniqueIndexAnnotation("IX_Flight_Seat_Flight_Number", 1);

            Property(p => p.Number)
                .IsRequired()
                .HasMaxLength(3)
                .HasUniqueIndexAnnotation("IX_Flight_Seat_Flight_Number", 2);
        }
    }
}