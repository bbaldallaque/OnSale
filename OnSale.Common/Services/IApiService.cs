using OnSale.Common.Responses;
using System.Threading.Tasks;

namespace OnSale.Common
{
    public interface IApiService
    {
        Task<Response> GetListAsync<T>(string urlBase, string servicePrefix, string controller);
    }
}
