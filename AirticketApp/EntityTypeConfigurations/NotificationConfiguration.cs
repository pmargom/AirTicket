using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using AirticketApp.Models;

namespace AirticketApp.EntityTypeConfigurations
{
    public class NotificationConfiguration: EntityTypeConfiguration<Notification>
    {
        public NotificationConfiguration()
        {
            Property(p => p.DateOfSent)
                .IsRequired();

            Property(p => p.Content)
                .IsRequired()
                .HasMaxLength(2000);
        }
    }
}