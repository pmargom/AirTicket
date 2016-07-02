namespace AirticketApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCreditCard1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CreditCards",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Number = c.String(),
                        Type = c.Int(nullable: false),
                        ExpirationMonth = c.String(),
                        ExpirationYear = c.String(),
                        PublicUserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PublicUsers", t => t.PublicUserId, cascadeDelete: true)
                .Index(t => t.PublicUserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CreditCards", "PublicUserId", "dbo.PublicUsers");
            DropIndex("dbo.CreditCards", new[] { "PublicUserId" });
            DropTable("dbo.CreditCards");
        }
    }
}
