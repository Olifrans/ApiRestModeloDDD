using ApiRestModeloDDD.Domain.Core.Interfaces.Repositorys;
using ApiRestModeloDDD.Domain.Core.Interfaces.Services;
using ApiRestModeloDDD.Domain.Entitys;

namespace ApiRestModeloDDD.Domain.Services
{
    public class ServiceProduto : ServiceBase<Produto>, IServiceProduto
    {
        private IRepositoryProduto _repositoryProduto;

        public ServiceProduto(IRepositoryProduto repositoryProduto)
            : base(repositoryProduto)
        {
            this._repositoryProduto = repositoryProduto;
        }
    }
}