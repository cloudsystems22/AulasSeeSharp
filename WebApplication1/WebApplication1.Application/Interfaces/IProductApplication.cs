using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.Application.Dtos;

namespace WebApplication1.Application.Interfaces
{
    public interface IProductApplication
    {
        void Add(ProductDto productDto);

        void Update(ProductDto productDto);

        void Remove(ProductDto productDto);

        IEnumerable<ProductDto> GetAll();

        ProductDto GetById(string id);
    }
}
