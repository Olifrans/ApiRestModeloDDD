using ApiRestModeloDDD.App.Dtos;
using ApiRestModeloDDD.Domain.Entitys;
using ApiRestModeloDDD.Infrastructure.CrossCuting.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace ApiRestModeloDDD.Infrastructure.CrossCuting.Mapper
{
    public class MapperCliente : IMapperCliente
    {
        public IMapperCliente MapperDtoToEntity(ClienteDto clienteDto)
        {
            var dadoscliente = new Cliente()
            {
                Id = clienteDto.Id,

                Nome = clienteDto.Nome,

                Sobrenome = clienteDto.Sobrenome,

                Email = clienteDto.Email
            };
            //return dadoscliente;
            return (IMapperCliente)dadoscliente;
        }

        public ClienteDto MapperEntityToDto(Cliente cliente)
        {
            var dadosclienteDto = new ClienteDto()
            {
                Id = cliente.Id,

                Nome = cliente.Nome,

                Sobrenome = cliente.Sobrenome,

                Email = cliente.Email
            };
            return dadosclienteDto;
        }

        public IEnumerable<ClienteDto> MapperListClientesDto(IEnumerable<Cliente> clientes)
        {
            var dto = clientes.Select(lista => new ClienteDto
            {
                Id = lista.Id,

                Nome = lista.Nome,

                Sobrenome = lista.Sobrenome,

                Email = lista.Email
            });
            //return dto;
            return (IEnumerable<ClienteDto>)dto;
        }
    }
}