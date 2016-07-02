using System.Data.Entity.ModelConfiguration;
using AirticketApp.Models;

namespace AirticketApp.EntityTypeConfigurations
{
    public class AircraftConfiguration: EntityTypeConfiguration<Aircraft>
    {
        public AircraftConfiguration()
        {
            Property(a => a.Type)
                .IsRequired()
                .HasMaxLength(30);
        }
    }
}