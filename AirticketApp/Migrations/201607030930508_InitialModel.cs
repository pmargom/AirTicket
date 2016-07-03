namespace AirticketApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Airlines",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Airports",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        City = c.String(nullable: false, maxLength: 75),
                        Country = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Aircraft",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(nullable: false, maxLength: 30),
                        AirlineId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Airlines", t => t.AirlineId, cascadeDelete: true)
                .Index(t => t.AirlineId);
            
            CreateTable(
                "dbo.Notifications",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateOfSent = c.DateTime(nullable: false),
                        Content = c.String(nullable: false, maxLength: 2000),
                        PublicUserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PublicUsers", t => t.PublicUserId, cascadeDelete: true)
                .Index(t => t.PublicUserId);
            
            CreateTable(
                "dbo.PublicUsers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Email = c.String(nullable: false, maxLength: 255),
                        Password = c.String(nullable: false, maxLength: 8),
                        Status = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 50),
                        Phone = c.String(nullable: false, maxLength: 15),
                        Direction = c.String(nullable: false, maxLength: 150),
                        ZipCode = c.String(nullable: false, maxLength: 6),
                        City = c.String(nullable: false, maxLength: 75),
                        Country = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Email, unique: true, name: "IX_PublicUser_Email");
            
            CreateTable(
                "dbo.Bookings",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Reference = c.String(nullable: false, maxLength: 50),
                        DateTime = c.DateTime(nullable: false),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Status = c.Int(nullable: false),
                        PublicUserId = c.Int(nullable: false),
                        UpdateByUserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AirlineUsers", t => t.UpdateByUserId, cascadeDelete: true)
                .ForeignKey("dbo.PublicUsers", t => t.PublicUserId, cascadeDelete: true)
                .Index(t => t.Reference, unique: true, name: "IX_Booking_Reference")
                .Index(t => t.PublicUserId)
                .Index(t => t.UpdateByUserId);
            
            CreateTable(
                "dbo.AirlineUsers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(nullable: false, maxLength: 30),
                        Password = c.String(nullable: false, maxLength: 16),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "IX_AirlineUser_UserName");
            
            CreateTable(
                "dbo.Flights",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Number = c.String(nullable: false, maxLength: 20),
                        AirlineId = c.Int(nullable: false),
                        UpdateByUserId = c.Int(nullable: false),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Airlines", t => t.AirlineId, cascadeDelete: true)
                .ForeignKey("dbo.AirlineUsers", t => t.UpdateByUserId, cascadeDelete: true)
                .Index(t => t.Number, unique: true, name: "IX_Flight_Number")
                .Index(t => t.AirlineId)
                .Index(t => t.UpdateByUserId);
            
            CreateTable(
                "dbo.Seats",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Number = c.String(nullable: false, maxLength: 3),
                        FlightId = c.Int(nullable: false),
                        FlightNumber = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Flights", t => t.FlightId, cascadeDelete: true)
                .Index(t => new { t.FlightNumber, t.Number }, unique: true, name: "IX_Flight_Seat_Flight_Number")
                .Index(t => t.FlightId);
            
            CreateTable(
                "dbo.BoardingPasses",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        BookingId = c.Long(nullable: false),
                        DateOfCreation = c.DateTime(nullable: false),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Bookings", t => t.BookingId)
                .Index(t => t.BookingId);
            
            CreateTable(
                "dbo.Passengers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdentificationOfPassenger = c.String(nullable: false, maxLength: 15),
                        BookingId = c.Long(nullable: false),
                        Name = c.String(nullable: false, maxLength: 50),
                        Phone = c.String(nullable: false, maxLength: 15),
                        Direction = c.String(nullable: false, maxLength: 150),
                        ZipCode = c.String(nullable: false, maxLength: 6),
                        City = c.String(nullable: false, maxLength: 75),
                        Country = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Bookings", t => t.BookingId)
                .Index(t => new { t.IdentificationOfPassenger, t.BookingId }, unique: true, name: "IX_Passengers_PassenderId_Booking_Id");
            
            CreateTable(
                "dbo.CreditCards",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 30),
                        Number = c.String(nullable: false, maxLength: 16),
                        Type = c.Int(nullable: false),
                        ExpirationMonth = c.String(nullable: false, maxLength: 2),
                        ExpirationYear = c.String(nullable: false, maxLength: 4),
                        PublicUserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PublicUsers", t => t.PublicUserId, cascadeDelete: true)
                .Index(t => new { t.Name, t.Number }, unique: true, name: "IX_CreditCard_Name_Number")
                .Index(t => t.PublicUserId);
            
            CreateTable(
                "dbo.Payments",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        BookingId = c.Long(nullable: false),
                        Reference = c.String(nullable: false, maxLength: 20),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Bookings", t => t.BookingId, cascadeDelete: true)
                .Index(t => t.BookingId)
                .Index(t => t.Reference, unique: true, name: "IX_Payment_Reference");
            
            CreateTable(
                "dbo.Departures",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Time = c.DateTime(nullable: false),
                        AirPortId = c.Int(nullable: false),
                        FlightId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Airports", t => t.AirPortId, cascadeDelete: true)
                .ForeignKey("dbo.Flights", t => t.FlightId, cascadeDelete: true)
                .Index(t => new { t.FlightId, t.Date, t.Time }, unique: true, name: "IX_Flight_Id_Departure_Date_Time")
                .Index(t => t.AirPortId);
            
            CreateTable(
                "dbo.Arrivals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Time = c.DateTime(nullable: false),
                        AirPortId = c.Int(nullable: false),
                        FlightId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Airports", t => t.AirPortId, cascadeDelete: true)
                .ForeignKey("dbo.Flights", t => t.FlightId, cascadeDelete: true)
                .Index(t => new { t.FlightId, t.Date, t.Time }, unique: true, name: "IX_Flight_Id_Arrival_Date_Time")
                .Index(t => t.AirPortId);
            
            CreateTable(
                "dbo.BookinFlights",
                c => new
                    {
                        BookingId = c.Long(nullable: false),
                        FlightId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.BookingId, t.FlightId })
                .ForeignKey("dbo.Bookings", t => t.BookingId, cascadeDelete: false)
                .ForeignKey("dbo.Flights", t => t.FlightId, cascadeDelete: false)
                .Index(t => t.BookingId)
                .Index(t => t.FlightId);
            
            CreateTable(
                "dbo.CreditCardPayments",
                c => new
                    {
                        CreditCardId = c.Int(nullable: false),
                        PaymentId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => new { t.CreditCardId, t.PaymentId })
                .ForeignKey("dbo.CreditCards", t => t.CreditCardId, cascadeDelete: false)
                .ForeignKey("dbo.Payments", t => t.PaymentId, cascadeDelete: false)
                .Index(t => t.CreditCardId)
                .Index(t => t.PaymentId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Arrivals", "FlightId", "dbo.Flights");
            DropForeignKey("dbo.Arrivals", "AirPortId", "dbo.Airports");
            DropForeignKey("dbo.Departures", "FlightId", "dbo.Flights");
            DropForeignKey("dbo.Departures", "AirPortId", "dbo.Airports");
            DropForeignKey("dbo.Notifications", "PublicUserId", "dbo.PublicUsers");
            DropForeignKey("dbo.CreditCards", "PublicUserId", "dbo.PublicUsers");
            DropForeignKey("dbo.CreditCardPayments", "PaymentId", "dbo.Payments");
            DropForeignKey("dbo.CreditCardPayments", "CreditCardId", "dbo.CreditCards");
            DropForeignKey("dbo.Payments", "BookingId", "dbo.Bookings");
            DropForeignKey("dbo.Bookings", "PublicUserId", "dbo.PublicUsers");
            DropForeignKey("dbo.Passengers", "BookingId", "dbo.Bookings");
            DropForeignKey("dbo.BookinFlights", "FlightId", "dbo.Flights");
            DropForeignKey("dbo.BookinFlights", "BookingId", "dbo.Bookings");
            DropForeignKey("dbo.BoardingPasses", "BookingId", "dbo.Bookings");
            DropForeignKey("dbo.Flights", "UpdateByUserId", "dbo.AirlineUsers");
            DropForeignKey("dbo.Seats", "FlightId", "dbo.Flights");
            DropForeignKey("dbo.Flights", "AirlineId", "dbo.Airlines");
            DropForeignKey("dbo.Bookings", "UpdateByUserId", "dbo.AirlineUsers");
            DropForeignKey("dbo.Aircraft", "AirlineId", "dbo.Airlines");
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropIndex("dbo.CreditCardPayments", new[] { "PaymentId" });
            DropIndex("dbo.CreditCardPayments", new[] { "CreditCardId" });
            DropIndex("dbo.BookinFlights", new[] { "FlightId" });
            DropIndex("dbo.BookinFlights", new[] { "BookingId" });
            DropIndex("dbo.Arrivals", new[] { "AirPortId" });
            DropIndex("dbo.Arrivals", "IX_Flight_Id_Arrival_Date_Time");
            DropIndex("dbo.Departures", new[] { "AirPortId" });
            DropIndex("dbo.Departures", "IX_Flight_Id_Departure_Date_Time");
            DropIndex("dbo.Payments", "IX_Payment_Reference");
            DropIndex("dbo.Payments", new[] { "BookingId" });
            DropIndex("dbo.CreditCards", new[] { "PublicUserId" });
            DropIndex("dbo.CreditCards", "IX_CreditCard_Name_Number");
            DropIndex("dbo.Passengers", "IX_Passengers_PassenderId_Booking_Id");
            DropIndex("dbo.BoardingPasses", new[] { "BookingId" });
            DropIndex("dbo.Seats", new[] { "FlightId" });
            DropIndex("dbo.Seats", "IX_Flight_Seat_Flight_Number");
            DropIndex("dbo.Flights", new[] { "UpdateByUserId" });
            DropIndex("dbo.Flights", new[] { "AirlineId" });
            DropIndex("dbo.Flights", "IX_Flight_Number");
            DropIndex("dbo.AirlineUsers", "IX_AirlineUser_UserName");
            DropIndex("dbo.Bookings", new[] { "UpdateByUserId" });
            DropIndex("dbo.Bookings", new[] { "PublicUserId" });
            DropIndex("dbo.Bookings", "IX_Booking_Reference");
            DropIndex("dbo.PublicUsers", "IX_PublicUser_Email");
            DropIndex("dbo.Notifications", new[] { "PublicUserId" });
            DropIndex("dbo.Aircraft", new[] { "AirlineId" });
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropTable("dbo.CreditCardPayments");
            DropTable("dbo.BookinFlights");
            DropTable("dbo.Arrivals");
            DropTable("dbo.Departures");
            DropTable("dbo.Payments");
            DropTable("dbo.CreditCards");
            DropTable("dbo.Passengers");
            DropTable("dbo.BoardingPasses");
            DropTable("dbo.Seats");
            DropTable("dbo.Flights");
            DropTable("dbo.AirlineUsers");
            DropTable("dbo.Bookings");
            DropTable("dbo.PublicUsers");
            DropTable("dbo.Notifications");
            DropTable("dbo.Aircraft");
            DropTable("dbo.Airports");
            DropTable("dbo.Airlines");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
        }
    }
}
