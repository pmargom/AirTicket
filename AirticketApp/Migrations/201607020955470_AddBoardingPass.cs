namespace AirticketApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBoardingPass : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BoardingPasses",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        BookingId = c.Long(nullable: false),
                        DateTime = c.DateTime(nullable: false),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Bookings", t => t.BookingId, cascadeDelete: true)
                .Index(t => t.BookingId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BoardingPasses", "BookingId", "dbo.Bookings");
            DropIndex("dbo.BoardingPasses", new[] { "BookingId" });
            DropTable("dbo.BoardingPasses");
        }
    }
}
