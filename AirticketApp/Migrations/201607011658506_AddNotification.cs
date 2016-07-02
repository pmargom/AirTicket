namespace AirticketApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNotification : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Notifications",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateTime = c.DateTime(nullable: false),
                        Content = c.String(),
                        PublicUserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PublicUsers", t => t.PublicUserId, cascadeDelete: true)
                .Index(t => t.PublicUserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Notifications", "PublicUserId", "dbo.PublicUsers");
            DropIndex("dbo.Notifications", new[] { "PublicUserId" });
            DropTable("dbo.Notifications");
        }
    }
}
