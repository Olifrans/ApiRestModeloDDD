using ApiRestModeloDDD.App.Dtos;
using ApiRestModeloDDD.Domain.Entitys;
using System.Collections.Generic;

namespace ApiRestModeloDDD.Infrastructure.CrossCuting.Interfaces
{
    public interface IMapperProduto //Map construido manualmente - Realiza o mapeamento de ProdutoDto
    {
        IMapperProduto MapperDtoToEntity(ProdutoDto produtoDto);

        IEnumerable<ProdutoDto> MapperListProdutosDto(IEnumerable<Produto> produtos);

        ProdutoDto MapperEntityToDto(Produto produto);
    }
}