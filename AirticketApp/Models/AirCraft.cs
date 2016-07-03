namespace AirticketApp.Models
{
    public class Aircraft
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public Airline Airline { get; set; }
        public int AirlineId { get; set; }
    }
}