using ApiRestModeloDDD.App.Dtos;
using ApiRestModeloDDD.App.Interfaces;
using ApiRestModeloDDD.App.Interfaces.Mappers;
using ApiRestModeloDDD.Domain.Core.Interfaces.Services;
using System.Collections.Generic;

namespace ApiRestModeloDDD.App
{
    public class ApplicationServiceCliente : IApplicationServiceCliente
    {
        private readonly IServiceCliente _serviceCliente;
        private readonly IMapperCliente _mapperCliente;

        public ApplicationServiceCliente(IServiceCliente serviceCliente, IMapperCliente mapperCliente)
        {
            this._serviceCliente = serviceCliente;
            this._mapperCliente = mapperCliente;
        }

        public void Add(ClienteDto clienteDto)
        {
            var cliente = _mapperCliente.MapperDtoToEntity(clienteDto);
            //_serviceCliente.Add(cliente);
            _serviceCliente.Add((Domain.Entitys.Cliente)cliente);
        }

        public IEnumerable<ClienteDto> GetAll()
        {
            var clientes = _serviceCliente.GetAll();
            return _mapperCliente.MapperListClientesDto(clientes);
        }

        public ClienteDto GetById(int id)
        {
            var clientes = _serviceCliente.GetById(id);
            return _mapperCliente.MapperEntityToDto(clientes);
        }

        public void Remove(ClienteDto clienteDto)
        {
            var clientes = _mapperCliente.MapperDtoToEntity(clienteDto);
            //_serviceCliente.Remove(clientes);
            _serviceCliente.Remove((Domain.Entitys.Cliente)clientes);
        }

        public void Update(ClienteDto clienteDto)
        {
            var clientes = _mapperCliente.MapperDtoToEntity(clienteDto);
            //_serviceCliente.Update(clientes);
            _serviceCliente.Update((Domain.Entitys.Cliente)clientes);
        }
    }
}