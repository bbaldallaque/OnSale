using System.ComponentModel.DataAnnotations;

namespace OnSale.Model.Entities
{
    public class Country
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage ="The field {0} must contais less than {1} characters")]
        public string Name { get; set; }
    }
}
