using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace OnSale.Model.ViewModel
{
    public class AddProductImageViewModel
    {
        public int ProductId { get; set; }

        [Display(Name = "Image")]
        [Required]
        public IFormFile ImageFile { get; set; }
    }

}
