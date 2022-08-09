using System.Collections.Generic;
using WebApplication1.Application.Dtos;

namespace WebApplication1.Application.Interfaces
{
    public interface IClienteApplication
    {
        void Add(ClienteDto clienteDto);

        void Update(ClienteDto clienteDto);

        void Remove(ClienteDto clienteDto);

        IEnumerable<ClienteDto> GetAll();

        ClienteDto GetById(string id);
    }
}
