using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using AirticketApp.Models;

namespace AirticketApp.EntityTypeConfigurations
{
    public class AirportConfiguration: EntityTypeConfiguration<Airport>
    {
        public AirportConfiguration()
        {
            Property(a => a.Name)
                .IsRequired()
                .HasMaxLength(50);

            Property(a => a.City)
                .IsRequired()
                .HasMaxLength(75);

            Property(a => a.Country)
                .IsRequired()
                .HasMaxLength(30);
        }
    }
}