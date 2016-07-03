namespace AirticketApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class PopulateArrivals : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Arrivals(Date, Time, AirPortId, FlightId) VALUES('2016-08-10', '08:00', 1, 1)");
            Sql("INSERT INTO Arrivals(Date, Time, AirPortId, FlightId) VALUES('2016-08-10', '08:30', 2, 2)");
            Sql("INSERT INTO Arrivals(Date, Time, AirPortId, FlightId) VALUES('2016-08-10', '10:00', 2, 3)");
            Sql("INSERT INTO Arrivals(Date, Time, AirPortId, FlightId) VALUES('2016-08-10', '12:10', 3, 4)");
        }

        public override void Down()
        {
        }
    }
}
