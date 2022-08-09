using System;
using System.Collections.Generic;
using WebApplication1.Application.Dtos;
using WebApplication1.Application.Interfaces;
using WebApplication1.Application.Interfaces.Mappers;
using WebApplication1.Domain.Core.Interfaces.Services;

namespace WebApplication1.Application
{
    public class ProductApplication : IProductApplication
    {
        private readonly IProductService productService;
        private readonly IProductMapper productMapper;

        public ProductApplication(IProductService productService, 
            IProductMapper productMapper)
        {
            this.productService = productService;
            this.productMapper = productMapper;

        }

        public void Add(ProductDto productDto)
        {
            var product = productMapper.MapperDtoToEntity(productDto);
            productService.Add(product);
        }

        public IEnumerable<ProductDto> GetAll()
        {
            var products = productService.GetAll();
            return productMapper.MapperListProductsDto(products);
        }

        public ProductDto GetById(string id)
        {
            var product = productService.GetById(id);
            return productMapper.MapperEntityToDto(product);
        }

        public void Remove(ProductDto productDto)
        {
            var product = productMapper.MapperDtoToEntity(productDto);
            productService.Remove(product);
        }

        public void Update(ProductDto productDto)
        {
            var product = productMapper.MapperDtoToEntity(productDto);
            productService.Update(product);
        }
    }
}
