using Application.DTOs.Product;
using Application.Helpers;
using AutoMapper;
using Domain.Entities;

namespace Application.Mapping
{
    public class MapConfig:Profile
    {
        public MapConfig()
        {
            CreateMap<Product, ReadProductDto>()
                .ForMember(dest => dest.Brand, opt => opt.MapFrom(src => src.Brand != null ? src.Brand.Name : null))
                .ForMember(dest => dest.Category, opt => opt.MapFrom(src => src.Category != null ? src.Category.Name : null))
                .ForMember(dest => dest.PictureUrl, opt => opt.MapFrom<ProductPictureUrlReslover>());
        }
    }
}
