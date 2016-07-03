namespace AirticketApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateFlights : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Flights(Number, AirlineId, UpdateByUserId, Status) VALUES('IB-100', 1, 1, 0)");
            Sql("INSERT INTO Flights(Number, AirlineId, UpdateByUserId, Status) VALUES('IB-101', 2, 1, 0)");
            Sql("INSERT INTO Flights(Number, AirlineId, UpdateByUserId, Status) VALUES('LT-345', 6, 2, 0)");
            Sql("INSERT INTO Flights(Number, AirlineId, UpdateByUserId, Status) VALUES('AF-234', 4, 3, 0)");
            Sql("INSERT INTO Flights(Number, AirlineId, UpdateByUserId, Status) VALUES('BA-802', 2, 2, 0)");
            Sql("INSERT INTO Flights(Number, AirlineId, UpdateByUserId, Status) VALUES('AB-981', 3, 3, 0)");
            Sql("INSERT INTO Flights(Number, AirlineId, UpdateByUserId, Status) VALUES('AF-765', 4, 4, 0)");
            Sql("INSERT INTO Flights(Number, AirlineId, UpdateByUserId, Status) VALUES('FA-134', 5, 3, 0)");
        }

        public override void Down()
        {
        }
    }
}
