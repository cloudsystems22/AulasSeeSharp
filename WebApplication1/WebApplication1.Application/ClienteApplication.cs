using System.Collections.Generic;
using WebApplication1.Application.Dtos;
using WebApplication1.Application.Interfaces;
using WebApplication1.Application.Interfaces.Mappers;
using WebApplication1.Domain.Core.Interfaces.Services;

namespace WebApplication1.Application
{
    public class ClienteApplication : IClienteApplication
    {
        private readonly IClienteService clienteService;
        private readonly IClienteMapper clienteMapper;

        public ClienteApplication(IClienteService clienteService,
            IClienteMapper clienteMapper)
        {
            this.clienteService = clienteService;
            this.clienteMapper = clienteMapper;
        }

        public void Add(ClienteDto clienteDto)
        {
            var cliente = clienteMapper.MapperDtoToEntity(clienteDto);
            clienteService.Add(cliente);
        }

        public IEnumerable<ClienteDto> GetAll()
        {
            var clientes = clienteService.GetAll();
            return clienteMapper.MapperListClientesDto(clientes);
        }

        public ClienteDto GetById(string id)
        {
            var clientes = clienteService.GetById(id);
            return clienteMapper.MapperEntityToDto(clientes);
        }

        public void Remove(ClienteDto clienteDto)
        {
            var cliente = clienteMapper.MapperDtoToEntity(clienteDto);
            clienteService.Remove(cliente);
        }

        public void Update(ClienteDto clienteDto)
        {
            var cliente = clienteMapper.MapperDtoToEntity(clienteDto);
            clienteService.Update(cliente);
        }
    }
}
