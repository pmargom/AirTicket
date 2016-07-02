using System.Data.Entity.ModelConfiguration;
using AirticketApp.Models;

namespace AirticketApp.EntityTypeConfigurations
{
    public class PaymentConfiguration: EntityTypeConfiguration<Payment>
    {
        public PaymentConfiguration()
        {
            Property(p => p.Reference)
                .IsRequired()
                .HasMaxLength(20)
                .HasUniqueIndexAnnotation("IX_Payment_Reference", 0);
        }
    }
}