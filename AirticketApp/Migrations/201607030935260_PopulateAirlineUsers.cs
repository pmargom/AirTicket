namespace AirticketApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateAirlineUsers : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO AirlineUsers (UserName, Password) VALUES ('staff1', '123456')");
            Sql("INSERT INTO AirlineUsers (UserName, Password) VALUES ('staff2', '123456')");
            Sql("INSERT INTO AirlineUsers (UserName, Password) VALUES ('staff3', '123456')");
            Sql("INSERT INTO AirlineUsers (UserName, Password) VALUES ('staff4', '123456')");
        }
        
        public override void Down()
        {
        }
    }
}
