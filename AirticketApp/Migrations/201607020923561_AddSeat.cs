namespace AirticketApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSeat : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Seats",
                c => new
                    {
                        FlightNumber = c.Long(nullable: false),
                        Time = c.DateTime(nullable: false),
                        Flight_Number = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => new { t.FlightNumber, t.Time })
                .ForeignKey("dbo.Flights", t => t.Flight_Number)
                .Index(t => t.Flight_Number);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Seats", "Flight_Number", "dbo.Flights");
            DropIndex("dbo.Seats", new[] { "Flight_Number" });
            DropTable("dbo.Seats");
        }
    }
}
