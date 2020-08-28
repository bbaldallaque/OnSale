﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using OnSale.Model.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OnSale.Model.ViewModel
{
    public class ProductViewModel : Product
    {
        [Display(Name = "Category")]
        [Range(1, int.MaxValue, ErrorMessage = "You must select a category.")]
        [Required]
        public int CategoryId { get; set; }

        [Display(Name = "Image")]
        public IFormFile ImageFile { get; set; }

        public IEnumerable<SelectListItem> Categories { get; set; }

        [Display(Name = "Price")]
        [MaxLength(12)]
        [RegularExpression(@"^\d+([\.\,]?\d+)?$", ErrorMessage = "Use only numbers and . or , to put decimals")]
        [Required]
        public string PriceString { get; set; }

    }
}
