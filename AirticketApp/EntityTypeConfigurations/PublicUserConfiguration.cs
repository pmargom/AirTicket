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
    public class PublicUserConfiguration:EntityTypeConfiguration<PublicUser>
    {
        public PublicUserConfiguration()
        {
            Property(p => p.Email)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnAnnotation("Index",
                    new IndexAnnotation(new IndexAttribute("IX_PublicUser_Email") {IsUnique = true}));

            Property(p => p.Password)
                .IsRequired()
                .HasMaxLength(8);

            Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(50);

            Property(p => p.Phone)
                .IsRequired()
                .HasMaxLength(15);

            Property(p => p.Direction)
                .IsRequired()
                .HasMaxLength(150);

            Property(p => p.ZipCode)
                .IsRequired()
                .HasMaxLength(6);

            Property(p => p.City)
                .IsRequired()
                .HasMaxLength(75);

            Property(p => p.Country)
                .IsRequired()
                .HasMaxLength(30);

            HasMany(p => p.Bookings)
                .WithRequired(p => p.PublicUser)
                .HasForeignKey(p => p.PublicUserId);

            HasMany(p => p.CreditCards)
                .WithRequired(p => p.PublicUser)
                .HasForeignKey(p => p.PublicUserId);

            HasMany(p => p.Notifications)
                .WithRequired(p => p.PublicUser)
                .HasForeignKey(p => p.PublicUserId);

        }
    }
}