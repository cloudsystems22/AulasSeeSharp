using System.Collections.Generic;
using WebApplication1.Application.Dtos;
using WebApplication1.Domain.Entities;

namespace WebApplication1.Application.Interfaces.Mappers
{
    public interface IProductMapper
    {
        Product MapperDtoToEntity(ProductDto productDto);

        IEnumerable<ProductDto> MapperListProductsDto(IEnumerable<Product> products);

        ProductDto MapperEntityToDto(Product product);
    }
}
