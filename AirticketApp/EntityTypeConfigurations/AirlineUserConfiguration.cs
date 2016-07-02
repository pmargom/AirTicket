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
    public class AirlineUserConfiguration: EntityTypeConfiguration<AirlineUser>
    {
        public AirlineUserConfiguration()
        {
            Property(p => p.UserName)
                .IsRequired()
                .HasMaxLength(30).HasColumnAnnotation("Index",
                    new IndexAnnotation(new IndexAttribute("IX_AirlineUser_UserName") { IsUnique = true }));

            Property(p => p.Password)
                .IsRequired()
                .HasMaxLength(16);

            HasMany(p => p.Flights)
                .WithRequired(p => p.AirlineUser)
                .HasForeignKey(p => p.AirlineUserId);

            HasMany(p => p.Bookings)
                .WithRequired(p => p.AirlineUser)
                .HasForeignKey(p => p.AirlineUserId);

        }
    }
}