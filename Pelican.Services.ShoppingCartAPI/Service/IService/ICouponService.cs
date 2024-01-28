using Pelican.Services.ShoppingCartAPI.Models.Dto;

namespace Pelican.Services.ShoppingCartAPI.Service.IService
{
    public interface ICouponService
    {
        Task<CouponDto> GetCoupon(string couponCode);
    }
}
