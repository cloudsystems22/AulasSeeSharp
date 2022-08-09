using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.Domain.Core.Interfaces.Repositories;
using WebApplication1.Domain.Entities;
using WebApplication1.Infrastrucure.Data.MSSqlcontext;

namespace WebApplication1.Infrastrucure.Data.Repositories
{
    public class ClienteRepository : BaseRepository<Cliente>, IClienteRepository
    {
        private readonly MSSqlContext mSSqlContext;

        public ClienteRepository(MSSqlContext mSSqlContext)
            :base(mSSqlContext)
        {
            this.mSSqlContext = mSSqlContext;
        }
    }
}
