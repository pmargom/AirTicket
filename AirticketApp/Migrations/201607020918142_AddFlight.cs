namespace AirticketApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFlight : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Flights",
                c => new
                    {
                        Number = c.String(nullable: false, maxLength: 128),
                        AirlineId = c.Int(nullable: false),
                        UpdatedByUserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Number)
                .ForeignKey("dbo.Airlines", t => t.AirlineId, cascadeDelete: true)
                .Index(t => t.AirlineId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Flights", "AirlineId", "dbo.Airlines");
            DropIndex("dbo.Flights", new[] { "AirlineId" });
            DropTable("dbo.Flights");
        }
    }
}
