using ApiRestModeloDDD.App.Dtos;
using ApiRestModeloDDD.App.Interfaces.Mappers;
using ApiRestModeloDDD.Domain.Entitys;
using System.Collections.Generic;
using System.Linq;

namespace ApiRestModeloDDD.App.Mappers
{
    public class MapperProduto : IMapperProduto
    {
        public IMapperProduto MapperDtoToEntity(ProdutoDto produtoDto)
        {
            var dadosproduto = new Produto()
            {
                Id = produtoDto.Id,
                Nome = produtoDto.Nome,
                Valor = produtoDto.Valor
            };
            //return dadosproduto;
            return (IMapperProduto)dadosproduto;
        }

        public ProdutoDto MapperEntityToDto(Produto produto)
        {
            var dadosprodutosDto = new ProdutoDto()
            {
                Id = produto.Id,
                Nome = produto.Nome,
                Valor = produto.Valor,
            };
            return dadosprodutosDto;
        }

        public IEnumerable<ProdutoDto> MapperListProdutosDto(IEnumerable<Produto> produtos)
        {
            var dto = produtos.Select(lista => new ProdutoDto
            {
                Id = lista.Id,
                Nome = lista.Nome,
                Valor = lista.Valor
            });
            //return dto;
            return (IEnumerable<ProdutoDto>)dto;
        }
    }
}