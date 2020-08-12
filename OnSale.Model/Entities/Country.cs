using System.ComponentModel.DataAnnotations;

namespace OnSale.Model.Entities
{
    public class Country
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
