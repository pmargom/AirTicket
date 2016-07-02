namespace AirticketApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAirlineUser : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AirlineUsers",
                c => new
                    {
                        UserName = c.String(nullable: false, maxLength: 128),
                        Id = c.Int(nullable: false),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.UserName);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.AirlineUsers");
        }
    }
}
