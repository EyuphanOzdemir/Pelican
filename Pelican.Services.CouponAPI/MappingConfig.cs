using AutoMapper;
using Pelican.Services.CouponAPI.Models;
using Pelican.Services.CouponAPI.Models.Dto;

namespace Pelican.Services.CouponAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<CouponDto, Coupon>();
                config.CreateMap<Coupon, CouponDto>();
            });
            return mappingConfig;
        }
    }
}
