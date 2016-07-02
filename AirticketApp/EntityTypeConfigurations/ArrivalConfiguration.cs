using System.Data.Entity.ModelConfiguration;
using AirticketApp.Models;

namespace AirticketApp.EntityTypeConfigurations
{
    public class ArrivalConfiguration: EntityTypeConfiguration<Arrival>
    {
        public ArrivalConfiguration()
        {
            Property(p => p.FlightNumber)
                .IsRequired()
                .HasMaxLength(8)
                .HasUniqueIndexAnnotation("IX_Flight_Number_Arrival_Date_Time", 0);

            Property(p => p.DateOfDeparture)
                .IsRequired()
                .HasUniqueIndexAnnotation("IX_Flight_Number_Arrival_Date_Time", 1);

            Property(p => p.TimeOfDeparture)
                .IsRequired()
                .HasUniqueIndexAnnotation("IX_Flight_Number_Arrival_Date_Time", 2);
        }
    }
}