using System.Data.Entity.ModelConfiguration;
using AirticketApp.Models;

namespace AirticketApp.EntityTypeConfigurations
{
    public class AirlineConfiguration: EntityTypeConfiguration<Airline>
    {
        public AirlineConfiguration()
        {
            Property(a => a.Name)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}