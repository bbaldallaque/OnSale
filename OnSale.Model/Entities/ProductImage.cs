using System;
using System.ComponentModel.DataAnnotations;

namespace OnSale.Model.Entities
{
    public class ProductImage
    {
        public int Id { get; set; }

        [Display(Name = "Image")]
        public Guid ImageId { get; set; }

        [Display(Name = "Image")]
        public string ImageFullPath => ImageId == Guid.Empty
            ? $"https://onsalestewart.azurewebsites.net/images/noimage.png"
            : $"https://onsalebryant.blob.core.windows.net/products/{ImageId}";
    }

}
