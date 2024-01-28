using AutoMapper;
using Pelican.Services.ProductAPI.Models;
using Pelican.Services.ProductAPI.Models.Dto;

namespace Pelican.Services.ProductAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ProductDto, Product>().ReverseMap();
            });
            return mappingConfig;
        }
    }
}
