using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MoneyExchangeAPI.Models
{
    public class House
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int HouseId { get; set; }
        [Required]
        public string Name { get; set; }
        public double Buy { get; set; }
        public double Sell { get; set; }
        [MaxLength(500000)]
        public string Address { get; set; }
        public string Phone { get; set; }
        [MaxLength(500000)]
        public string GoogleMaps { get; set; }
        
        public int? CityId { get; set; }

        public City? City { get; set; }

        public int? UserId { get; set; }

        public Users? Users { get; set; }

    }
}
