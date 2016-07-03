using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using AirticketApp.EntityTypeConfigurations;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace AirticketApp.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Airport> Airports { get; set; }
        public DbSet<Airline> Airlines { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AirlineConfiguration());
            modelBuilder.Configurations.Add(new AirportConfiguration());
            modelBuilder.Configurations.Add(new AircraftConfiguration());
            modelBuilder.Configurations.Add(new NotificationConfiguration());
            modelBuilder.Configurations.Add(new AirlineUserConfiguration());
            modelBuilder.Configurations.Add(new BookingConfiguration());
            modelBuilder.Configurations.Add(new FlightConfiguration());
            modelBuilder.Configurations.Add(new PublicUserConfiguration());
            modelBuilder.Configurations.Add(new CreditCardConfiguration());
            modelBuilder.Configurations.Add(new PaymentConfiguration());
            modelBuilder.Configurations.Add(new DepartureConfiguration());
            modelBuilder.Configurations.Add(new ArrivalConfiguration());
            modelBuilder.Configurations.Add(new SeatConfiguration());
            modelBuilder.Configurations.Add(new BoardingPassConfiguration());
            modelBuilder.Configurations.Add(new PassengerConfiguration());
            
            base.OnModelCreating(modelBuilder);
        }

        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}