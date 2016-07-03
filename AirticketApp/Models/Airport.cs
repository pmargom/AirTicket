using System.ComponentModel.DataAnnotations;

namespace AirticketApp.Models
{
    public class Airport
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(75)]
        public string City { get; set; }

        [Required]
        [StringLength(30)]
        public string Country { get; set; }

    }
}