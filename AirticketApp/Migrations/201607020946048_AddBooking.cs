namespace AirticketApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBooking : DbMigration
    {
        public override void Up()
        {
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
                        UpdatedByUserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PublicUsers", t => t.PublicUserId, cascadeDelete: true)
                .Index(t => t.PublicUserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Bookings", "PublicUserId", "dbo.PublicUsers");
            DropIndex("dbo.Bookings", new[] { "PublicUserId" });
            DropTable("dbo.Bookings");
        }
    }
}
