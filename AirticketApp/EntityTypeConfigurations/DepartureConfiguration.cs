using System.Data.Entity.ModelConfiguration;
using AirticketApp.Models;

namespace AirticketApp.EntityTypeConfigurations
{
    public class DepartureConfiguration : EntityTypeConfiguration<Departure>
    {
        public DepartureConfiguration()
        {
            Property(p => p.FlightId)
                .IsRequired()
                .HasUniqueIndexAnnotation("IX_Flight_Id_Departure_Date_Time", 0);

            Property(p => p.Date)
                .IsRequired()
                .HasUniqueIndexAnnotation("IX_Flight_Id_Departure_Date_Time", 1);

            Property(p => p.Time)
                .IsRequired()
                .HasUniqueIndexAnnotation("IX_Flight_Id_Departure_Date_Time", 2);
        }
    }
}