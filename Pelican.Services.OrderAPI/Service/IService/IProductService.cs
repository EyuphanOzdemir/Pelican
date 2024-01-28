
using Pelican.Services.OrderAPI.Models.Dto;

namespace Pelican.Services.ShoppingCartAPI.Service.IService
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetProducts();
    }
}
