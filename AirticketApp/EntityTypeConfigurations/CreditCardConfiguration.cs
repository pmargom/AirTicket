using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using AirticketApp.Models;

namespace AirticketApp.EntityTypeConfigurations
{
    public class CreditCardConfiguration: EntityTypeConfiguration<CreditCard>
    {
        public CreditCardConfiguration()
        {
            Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(30)
                .HasUniqueIndexAnnotation("IX_CreditCard_Name_Number", 0);

            Property(p => p.Number)
                .IsRequired()
                .HasMaxLength(16)
                .HasUniqueIndexAnnotation("IX_CreditCard_Name_Number", 1);

            Property(p => p.ExpirationMonth)
                .IsRequired()
                .HasMaxLength(2);

            Property(p => p.ExpirationYear)
                .IsRequired()
                .HasMaxLength(4);

            HasMany(p => p.Payments)
                .WithMany(p => p.CreditCards)
                .Map(m =>
                {
                    m.ToTable("CreditCardPayments");
                    m.MapLeftKey("CreditCardId");
                    m.MapRightKey("PaymentId");
                });
        }
    }
}