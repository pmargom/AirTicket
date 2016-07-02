using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using AirticketApp.Models;

namespace AirticketApp.EntityTypeConfigurations
{
    public class FlightConfiguration: EntityTypeConfiguration<Flight>
    {
        public FlightConfiguration()
        {
            Property(p => p.Number)
                .IsRequired()
                .HasMaxLength(20)
                .HasColumnAnnotation("Index",
                    new IndexAnnotation(new IndexAttribute("IX_Flight_Number") {IsUnique = true}));

            Property(p => p.AirlineUserId)
                .HasColumnName("UpdateByUserId");

            HasMany(p => p.Seats)
                .WithRequired(p => p.Flight)
                .HasForeignKey(p => p.FlightId);

        }
    }
}