using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using OnSale.Model.Entities;

namespace OnSale.Model.ViewModel
{
    public class CategoryViewModel : Category
    {
        [Display(Name = "Image")]
        public IFormFile ImageFile { get; set; }
    }
}
