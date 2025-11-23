using Application.DTOs.Product;
using AutoMapper;
using Domain.Entities;
using Microsoft.Extensions.Configuration;

namespace Application.Helpers
{
    internal class ProductPictureUrlReslover : IValueResolver<Product, ReadProductDto, string?>
    {
        private readonly IConfiguration configuration;
        public ProductPictureUrlReslover(IConfiguration _configuration)
        {
            configuration = _configuration;
        }
        public string Resolve(Product source, ReadProductDto destination, string? destMember, ResolutionContext context)
        {
            if (!string.IsNullOrEmpty(source.PictureUrl))
            {
                var baseUri = configuration["BaseApiUrl"];
                return $"{baseUri}/{source.PictureUrl}";

            }
            return string.Empty;
        }
    }
}
