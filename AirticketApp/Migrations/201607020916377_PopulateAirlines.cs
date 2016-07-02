namespace AirticketApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateAirlines : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO AirLines (Name) VALUES ('Iberia')");
            Sql("INSERT INTO AirLines (Name) VALUES ('British Airways')");
            Sql("INSERT INTO AirLines (Name) VALUES ('Air Berlin')");
            Sql("INSERT INTO AirLines (Name) VALUES ('Air France')");
            Sql("INSERT INTO AirLines (Name) VALUES ('Finnair')");
            Sql("INSERT INTO AirLines (Name) VALUES ('Lufthansa')");
        }
        
        public override void Down()
        {
        }
    }
}
