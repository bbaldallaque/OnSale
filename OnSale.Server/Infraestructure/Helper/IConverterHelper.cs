using OnSale.Model.Entities;
using OnSale.Model.ViewModel;
using System;
using System.Threading.Tasks;

namespace OnSale.Server.Infraestructure.Helper
{
    public interface IConverterHelper
    {
        Category ToCategory(CategoryViewModel model, Guid imageId, bool isNew);

        CategoryViewModel ToCategoryViewModel(Category category);

        Task<Product> ToProductAsync(ProductViewModel model, bool isNew);

        ProductViewModel ToProductViewModel(Product product);

    }

}
