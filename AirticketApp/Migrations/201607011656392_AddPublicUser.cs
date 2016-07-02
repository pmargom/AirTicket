namespace AirticketApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPublicUser : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PublicUsers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Email = c.String(),
                        Password = c.String(),
                        Status = c.Byte(nullable: false),
                        Name = c.String(),
                        Phone = c.String(),
                        Direction = c.String(),
                        ZipCode = c.String(),
                        City = c.String(),
                        Country = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PublicUsers");
        }
    }
}
