using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace OnSale.Server.Infraestructure.Helper
{
    public interface ICombosHelper
    {
        IEnumerable<SelectListItem> GetComboCategories();
    }

}
