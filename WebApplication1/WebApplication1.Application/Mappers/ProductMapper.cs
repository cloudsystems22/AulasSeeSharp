using System.Collections.Generic;
using System.Linq;
using WebApplication1.Application.Dtos;
using WebApplication1.Application.Interfaces.Mappers;
using WebApplication1.Domain.Entities;

namespace WebApplication1.Application.Mappers
{
    public class ProductMapper : IProductMapper
    {
        IEnumerable<ProductDto> productDtos = new List<ProductDto>();

        public Product MapperDtoToEntity(ProductDto productDto)
        {
            var product = new Product()
            {
                Id = productDto.Id,
                Description = productDto.Description,
                Price = productDto.Price,
                IsActivity = productDto.IsActivity,
                CreateAt = productDto.CreateAt,
                UpdateAt = productDto.UpdateAt
            };

            return product;
        }

        public ProductDto MapperEntityToDto(Product product)
        {
            var productDto = new ProductDto()
            {
                Id = product.Id,
                Description = product.Description,
                Price = product.Price,
                IsActivity = product.IsActivity,
                CreateAt = product.CreateAt,
                UpdateAt = product.UpdateAt
            };

            return productDto;
        }

        public IEnumerable<ProductDto> MapperListProductsDto(IEnumerable<Product> products)
        {
            var iEnumerabelDto = products.Select(e => new ProductDto
            {
                Id = e.Id,
                Description = e.Description,
                Price = e.Price,
                IsActivity = e.IsActivity,
                CreateAt = e.CreateAt,
                UpdateAt = e.UpdateAt
            });

            return iEnumerabelDto;
        }
    }
}
