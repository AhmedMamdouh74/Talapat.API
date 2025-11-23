using Application.DTOs.Product;
using AutoMapper;
using Domain.Concrats;
using Domain.Entities;
using Domain.Specifications;
using Domain.Specifications.Products;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Talabat.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : BaseAPIController
    {
        private readonly IGenericRepository<Product> repository;
        private readonly IMapper mapper;

        public ProductsController(IGenericRepository<Product> _repository,IMapper _mapper)
        {
            repository = _repository;
            mapper = _mapper;
          
        }
        [HttpGet]
        public async Task<ActionResult<ReadProductDto>> GetProducts()
{
            var spec=new ProductWithCategoryAndBrandSpec();
            var products = await repository.GetAllWithSpecAsync(spec);
            var records= mapper.Map<List<ReadProductDto>>(products);
            return Ok(records);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<ReadProductDto>> GetProductById(int id)
        {
            var spec = new ProductWithCategoryAndBrandSpec(id);
            var product = await repository.GetByIdWithSpecAsync(spec);
            var record = mapper.Map<ReadProductDto>(product);
            return Ok(record);
        }
    }
}
