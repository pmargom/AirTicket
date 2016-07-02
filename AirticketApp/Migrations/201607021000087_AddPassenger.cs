namespace AirticketApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPassenger : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Passengers",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        BookingId = c.Long(nullable: false),
                        Name = c.String(nullable: false, maxLength: 30),
                        Phone = c.String(nullable: false, maxLength: 15),
                        Direction = c.String(nullable: false, maxLength: 150),
                        ZipCode = c.String(nullable: false, maxLength: 6),
                        City = c.String(nullable: false, maxLength: 75),
                        Country = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Bookings", t => t.BookingId, cascadeDelete: true)
                .Index(t => t.BookingId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Passengers", "BookingId", "dbo.Bookings");
            DropIndex("dbo.Passengers", new[] { "BookingId" });
            DropTable("dbo.Passengers");
        }
    }
}
