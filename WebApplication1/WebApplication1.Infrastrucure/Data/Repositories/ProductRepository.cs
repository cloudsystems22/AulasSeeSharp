using WebApplication1.Domain.Core.Interfaces.Repositories;
using WebApplication1.Domain.Entities;
using WebApplication1.Infrastrucure.Data.MSSqlcontext;

namespace WebApplication1.Infrastrucure.Data.Repositories
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {

        private readonly MSSqlContext mSSqlContext;

        public ProductRepository(MSSqlContext mSSqlContext)
            :base(mSSqlContext)
        {
            this.mSSqlContext = mSSqlContext;
        }
    }
}
