using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using AirticketApp.Models;

namespace AirticketApp.EntityTypeConfigurations
{
    public class BookingConfiguration: EntityTypeConfiguration<Booking>
    {
        public BookingConfiguration()
        {
            Property(p => p.Reference)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnAnnotation("Index",
                    new IndexAnnotation(new IndexAttribute("IX_Booking_Reference")
                    {
                        IsUnique = true
                    }));

            Property(p => p.Amount)
                .IsRequired();

            Property(p => p.AirlineUserId)
                .HasColumnName("UpdateByUserId");

            HasMany(p => p.Passengers)
                .WithRequired(p => p.Booking)
                .HasForeignKey(p => p.BookingId)
                .WillCascadeOnDelete(false);

            HasMany(p => p.BoardingPasses)
                .WithRequired(p => p.Booking)
                .HasForeignKey(p => p.BookingId)
                .WillCascadeOnDelete(false);

            HasMany(p => p.Flights)
                .WithMany(p => p.Bookings)
                .Map(m =>
                {
                    m.ToTable("BookinFlights");
                    m.MapLeftKey("BookingId");
                    m.MapRightKey("FlightId");
                });

        }
    }
}