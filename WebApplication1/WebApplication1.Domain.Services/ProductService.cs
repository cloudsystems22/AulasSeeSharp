using WebApplication1.Domain.Core.Interfaces.Repositories;
using WebApplication1.Domain.Core.Interfaces.Services;
using WebApplication1.Domain.Entities;

namespace WebApplication1.Domain.Services
{
    public class ProductService : BaseService<Product>, IProductService
    {
        private readonly IProductRepository productRepository;

        public ProductService(IProductRepository productRepository)
            :base(productRepository)
        {
            this.productRepository = productRepository;
        }
    }
}
