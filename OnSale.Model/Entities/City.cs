using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace OnSale.Model.Entities
{
    public class City
    {
        public int Id { get; set; }
       
        [Required]
        [MaxLength(50, ErrorMessage = "The field {0} must contais less than {1} characters")]
        public string Name { get; set; }


        [JsonIgnore]
        [NotMapped]
        public int IdDepartment { get; set; }
    }
}
