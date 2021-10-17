using ApiRestModeloDDD.Domain.Core.Interfaces.Repositorys;
using ApiRestModeloDDD.Domain.Core.Interfaces.Services;
using ApiRestModeloDDD.Domain.Entitys;

namespace ApiRestModeloDDD.Domain.Services
{
    public class ServiceCliente : ServiceBase<Cliente>, IServiceCliente
    {
        private IRepositoryCliente _repositoryCliente;

        public ServiceCliente(IRepositoryCliente repositoryCliente)
            : base(repositoryCliente)
        {
            this._repositoryCliente = repositoryCliente;
        }
    }
}