using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.Application.Dtos
{
    public class ProductDto
    {
        public string Id { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public Boolean IsActivity { get; set; }

        public DateTime CreateAt { get; set; }

        public DateTime UpdateAt { get; set; }
    }
}
