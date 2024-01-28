using Pelican.Services.ShoppingCartAPI.Models.Dto;

namespace Pelican.Services.ShoppingCartAPI.Service.IService
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetProducts();
    }
}
