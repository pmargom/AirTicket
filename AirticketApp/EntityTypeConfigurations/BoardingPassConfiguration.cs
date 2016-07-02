using System.Data.Entity.ModelConfiguration;
using AirticketApp.Models;

namespace AirticketApp.EntityTypeConfigurations
{
    public class BoardingPassConfiguration: EntityTypeConfiguration<BoardingPass>
    {
        public BoardingPassConfiguration()
        {
            Property(p => p.DateOfCreation)
                .IsRequired();

            Property(p => p.Status)
                .IsRequired();
            
        }
    }
}