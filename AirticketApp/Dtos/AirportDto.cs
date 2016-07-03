using System.ComponentModel.DataAnnotations;

namespace AirticketApp.Dtos
{
    public class AirportDto
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(75)]
        public string City { get; set; }

        [StringLength(30)]
        public string Country { get; set; }
    }
}