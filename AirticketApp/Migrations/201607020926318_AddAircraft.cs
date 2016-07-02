namespace AirticketApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAircraft : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Aircraft",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                        AirlineId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Airlines", t => t.AirlineId, cascadeDelete: true)
                .Index(t => t.AirlineId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Aircraft", "AirlineId", "dbo.Airlines");
            DropIndex("dbo.Aircraft", new[] { "AirlineId" });
            DropTable("dbo.Aircraft");
        }
    }
}
