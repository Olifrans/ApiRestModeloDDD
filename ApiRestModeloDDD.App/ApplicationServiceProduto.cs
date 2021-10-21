using ApiRestModeloDDD.App.Dtos;
using ApiRestModeloDDD.App.Interfaces;
using ApiRestModeloDDD.App.Interfaces.Mappers;
using ApiRestModeloDDD.Domain.Core.Interfaces.Services;
using System.Collections.Generic;

namespace ApiRestModeloDDD.App
{
    public class ApplicationServiceProduto : IApplicationServiceProduto
    {
        private readonly IServiceProduto _serviceProduto;
        private readonly IMapperProduto _mapperProduto;

        public ApplicationServiceProduto(IServiceProduto serviceProduto, IMapperProduto mapperProduto)
        {
            _serviceProduto = serviceProduto;
            _mapperProduto = mapperProduto;
        }

        public void Add(ProdutoDto produtoDto)
        {
            var produto = _mapperProduto.MapperDtoToEntity(produtoDto);
            //_serviceProduto.Add(produto);
            _serviceProduto.Add((Domain.Entitys.Produto)produto);
        }

        public IEnumerable<ProdutoDto> GetAll()
        {
            var produtos = _serviceProduto.GetAll();
            return _mapperProduto.MapperListProdutosDto(produtos);
        }

        public ProdutoDto GetById(int id)
        {
            var produtos = _serviceProduto.GetById(id);
            return _mapperProduto.MapperEntityToDto(produtos);
        }

        public void Remove(ProdutoDto produtoDto)
        {
            var produtos = _mapperProduto.MapperDtoToEntity(produtoDto);
            //_serviceCliente.Remove(clientes);
            _serviceProduto.Remove((Domain.Entitys.Produto)produtos);
        }

        public void Update(ProdutoDto produtoDto)
        {
            var produtos = _mapperProduto.MapperDtoToEntity(produtoDto);
            //_serviceCliente.Update(clientes);
            _serviceProduto.Update((Domain.Entitys.Produto)produtos);
        }
    }
}