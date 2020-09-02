using System.ComponentModel.DataAnnotations;

namespace OnSale.Model.ViewModel
{
    public class RecoverPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
