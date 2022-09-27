using AutoMapper;
using Eazie.Services.ProductAPI.Models;
using Eazie.Services.ProductAPI.Models.Dto;

namespace Eazie.Services.ProductAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<Product, ProductDto>().ReverseMap();
            });

            return mappingConfig;
        }
    }
}
