namespace AirticketApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateAirports : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Airports (Name, City, Country) VALUES ('Adolfo Suárez Madird Barajas', 'Madrid', 'Spain')");
            Sql("INSERT INTO Airports (Name, City, Country) VALUES ('El Prat', 'Barcelona', 'Spain')");
            Sql("INSERT INTO Airports (Name, City, Country) VALUES ('Los Rodeos', 'Santa Cruz de Tenerife', 'Spain')");
            Sql("INSERT INTO Airports (Name, City, Country) VALUES ('Reina Sofía', 'Santa Cruz de Tenerife', 'Spain')");
            Sql("INSERT INTO Airports (Name, City, Country) VALUES ('JFK', 'New York City', 'USA')");
            Sql("INSERT INTO Airports (Name, City, Country) VALUES ('Heathrow', 'London', 'England')");
            Sql("INSERT INTO Airports (Name, City, Country) VALUES ('Gatwick', 'London', 'England')");
            Sql("INSERT INTO Airports (Name, City, Country) VALUES ('Charles de Gaulle', 'Paris', 'France')");
            Sql("INSERT INTO Airports (Name, City, Country) VALUES ('Fiumicino', 'Roma', 'Italy')");
            Sql("INSERT INTO Airports (Name, City, Country) VALUES ( 'Malpensa', 'Milan', 'Italy')");
        }
        
        public override void Down()
        {
        }
    }
}
