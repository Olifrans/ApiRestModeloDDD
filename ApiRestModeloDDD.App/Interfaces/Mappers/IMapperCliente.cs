using ApiRestModeloDDD.App.Dtos;
using ApiRestModeloDDD.Domain.Entitys;
using System.Collections.Generic;

namespace ApiRestModeloDDD.App.Interfaces.Mappers
{
    public interface IMapperCliente // //Map construido manualmente - Realiza o mapeamento de ClienteDto
    {
        IMapperCliente MapperDtoToEntity(ClienteDto clienteDto);

        IEnumerable<ClienteDto> MapperListClientesDto(IEnumerable<Cliente> clientes);

        ClienteDto MapperEntityToDto(Cliente cliente);
    }
}