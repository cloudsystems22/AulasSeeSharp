using WebApplication1.Domain.Core.Interfaces.Repositories;
using WebApplication1.Domain.Core.Interfaces.Services;
using WebApplication1.Domain.Entities;

namespace WebApplication1.Domain.Services
{
    public class ClienteService : BaseService<Cliente>, IClienteService
    {
        private readonly IClienteRepository clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
            : base(clienteRepository)
        {
            this.clienteRepository = clienteRepository;
        }
    }
}
