using OnSale.Model.Entities;
using OnSale.Model.ViewModel;
using System;

namespace OnSale.Model.Infraestructure.Helper
{
    public interface IConverterHelper
    {
        Category ToCategory(CategoryViewModel model, Guid imageId, bool isNew);

        CategoryViewModel ToCategoryViewModel(Category category);
    }

}
