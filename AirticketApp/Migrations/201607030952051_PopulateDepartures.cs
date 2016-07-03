namespace AirticketApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class PopulateDepartures : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Departures(Date, Time, AirPortId, FlightId) VALUES('2016-08-10', '08:00', 4, 1)");
            Sql("INSERT INTO Departures(Date, Time, AirPortId, FlightId) VALUES('2016-08-10', '11:20', 6, 2)");
            Sql("INSERT INTO Departures(Date, Time, AirPortId, FlightId) VALUES('2016-08-10', '17:00', 7, 3)");
            Sql("INSERT INTO Departures(Date, Time, AirPortId, FlightId) VALUES('2016-08-10', '16:00', 8, 4)");
        }

        public override void Down()
        {
        }
    }
}
