using System;
using System.ComponentModel.DataAnnotations;

namespace OnSale.Model.Entities
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "The field {0} must contais less than {1} characters")]
        public string Name { get; set; }

        [Display(Name = "Image")]
        public Guid ImageId { get; set; }

        //TODO: Pending to put the correct paths
        [Display(Name = "Image")]
        public string ImageFullPath => ImageId == Guid.Empty
            ? $"https://localhost:44378/images/noimage.png"
            : $"https://onsalebryant.blob.core.windows.net/categories/{ImageId}";
    }

}
