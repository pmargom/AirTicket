using System.Data.Entity.ModelConfiguration;
using AirticketApp.Models;

namespace AirticketApp.EntityTypeConfigurations
{
    public class DepartureConfiguration : EntityTypeConfiguration<Departure>
    {
        public DepartureConfiguration()
        {
            Property(p => p.FlightNumber)
                .IsRequired()
                .HasMaxLength(8)
                .HasUniqueIndexAnnotation("IX_Flight_Number_Departure_Date_Time", 0);

            Property(p => p.DateOfDeparture)
                .IsRequired()
                .HasUniqueIndexAnnotation("IX_Flight_Number_Departure_Date_Time", 1);

            Property(p => p.TimeOfDeparture)
                .IsRequired()
                .HasUniqueIndexAnnotation("IX_Flight_Number_Departure_Date_Time", 2);
        }
    }
}