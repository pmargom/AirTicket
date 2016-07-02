namespace AirticketApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCreditCard : DbMigration
    {
        public override void Up()
        {
            //DropForeignKey("dbo.CreditCards", "PublicUserId", "dbo.PublicUsers");
            //DropIndex("dbo.CreditCards", new[] { "PublicUserId" });
            //DropTable("dbo.CreditCards");
        }
        
        public override void Down()
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
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.CreditCards", "PublicUserId");
            AddForeignKey("dbo.CreditCards", "PublicUserId", "dbo.PublicUsers", "Id", cascadeDelete: true);
        }
    }
}
