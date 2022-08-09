using System.Collections.Generic;
using System.Linq;
using WebApplication1.Application.Dtos;
using WebApplication1.Application.Interfaces.Mappers;
using WebApplication1.Domain.Entities;

namespace WebApplication1.Application.Mappers
{
    public class ClienteMapper : IClienteMapper
    {

        IEnumerable<ClienteDto> clienteDtos = new List<ClienteDto>();

        public Cliente MapperDtoToEntity(ClienteDto clienteDto)
        {
            var cliente = new Cliente()
            {
                Id = clienteDto.Id,
                Name = clienteDto.Name,
                LastName = clienteDto.LastName,
                EmailAddress = clienteDto.EmailAddress,
                IsActivity = clienteDto.IsActivity,
                CreateAt = clienteDto.CreateAt,
                UpdateAt = clienteDto.UpdateAt
            };

            return cliente;

        }

        public ClienteDto MapperEntityToDto(Cliente cliente)
        {
            var clienteDto = new ClienteDto()
            {
                Id = cliente.Id,
                Name = cliente.Name,
                LastName = cliente.LastName,
                EmailAddress = cliente.EmailAddress,
                IsActivity = cliente.IsActivity,
                CreateAt = cliente.CreateAt,
                UpdateAt = cliente.UpdateAt
            };

            return clienteDto;
        }

        public IEnumerable<ClienteDto> MapperListClientesDto(IEnumerable<Cliente> clientes)
        {
            var iEnumerabelDto = clientes.Select(e =>
                new ClienteDto
                {
                    Id = e.Id,
                    Name = e.Name,
                    LastName = e.LastName,
                    EmailAddress = e.EmailAddress,
                    IsActivity = e.IsActivity,
                    CreateAt = e.CreateAt,
                    UpdateAt = e.UpdateAt
                }
            );

            return iEnumerabelDto;
        }
    }
}
