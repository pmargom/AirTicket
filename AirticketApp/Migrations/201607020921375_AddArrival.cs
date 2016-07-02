namespace AirticketApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddArrival : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Arrivals",
                c => new
                    {
                        FlightNumber = c.String(nullable: false, maxLength: 128),
                        Date = c.DateTime(nullable: false),
                        Time = c.DateTime(nullable: false),
                        AirPortId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.FlightNumber, t.Date, t.Time })
                .ForeignKey("dbo.Airports", t => t.AirPortId, cascadeDelete: true)
                .ForeignKey("dbo.Flights", t => t.FlightNumber, cascadeDelete: true)
                .Index(t => t.FlightNumber)
                .Index(t => t.AirPortId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Arrivals", "FlightNumber", "dbo.Flights");
            DropForeignKey("dbo.Arrivals", "AirPortId", "dbo.Airports");
            DropIndex("dbo.Arrivals", new[] { "AirPortId" });
            DropIndex("dbo.Arrivals", new[] { "FlightNumber" });
            DropTable("dbo.Arrivals");
        }
    }
}
