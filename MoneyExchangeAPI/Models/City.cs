using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MoneyExchangeAPI.Models
{
    public class City
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CityId { get; set; }
        public string Name { get; set; }
        public string State { get; set; }
        public string Country { get; set; }

        public List<House>? Houses { get; set; }

    }
}
