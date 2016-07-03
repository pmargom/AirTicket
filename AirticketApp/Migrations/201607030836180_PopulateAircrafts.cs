namespace AirticketApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateAircrafts : DbMigration
    {
        public override void Up()
        {
           Sql("INSERT INTO Aircraft (Type, AirlineId) VALUES ('Airbus A-310', 1)");
           Sql("INSERT INTO Aircraft (Type, AirlineId) VALUES ('Airbus A-310', 2)");
           Sql("INSERT INTO Aircraft (Type, AirlineId) VALUES ('Airbus A-310', 3)");
           Sql("INSERT INTO Aircraft (Type, AirlineId) VALUES ('Airbus A-310', 6)");
           Sql("INSERT INTO Aircraft (Type, AirlineId) VALUES ('Boeing 737', 1)");
           Sql("INSERT INTO Aircraft (Type, AirlineId) VALUES ('Boeing 737', 4)");
           Sql("INSERT INTO Aircraft (Type, AirlineId) VALUES ('British Aerospace BAe 121', 2)");
           Sql("INSERT INTO Aircraft (Type, AirlineId) VALUES ('British Aerospace BAe 121', 5)");
           Sql("INSERT INTO Aircraft (Type, AirlineId) VALUES ('British Aerospace BAe 121', 4)");
           Sql("INSERT INTO Aircraft (Type, AirlineId) VALUES ('Airbus A-320', 2)");
           Sql("INSERT INTO Aircraft (Type, AirlineId) VALUES ('Airbus A-320', 4)");
           Sql("INSERT INTO Aircraft (Type, AirlineId) VALUES ('Airbus A-320', 6)");
           Sql("INSERT INTO Aircraft (Type, AirlineId) VALUES ('Concorde', 2)");
           Sql("INSERT INTO Aircraft (Type, AirlineId) VALUES ('Concorde', 3)");
        }
        
        public override void Down()
        {
        }
    }
}
