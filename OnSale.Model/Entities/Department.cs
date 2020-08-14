using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace OnSale.Model.Entities
{
    public class Department
    {
        public int Id { get; set; }

        [MaxLength(50)]
        [Required]
        public string Name { get; set; }

        public ICollection<City> Cities { get; set; }

        [DisplayName("Cities Number")]
        public int CitiesNumber => Cities == null ? 0 : Cities.Count;

        public int? CountryId { get; set; }

        public Country Country { get; set; }

        [JsonIgnore]
        [NotMapped]
        public int IdCountry { get; set; }
    }
}
