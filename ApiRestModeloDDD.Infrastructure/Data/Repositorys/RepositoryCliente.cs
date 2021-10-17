using ApiRestModeloDDD.Domain.Core.Interfaces.Repositorys;
using ApiRestModeloDDD.Domain.Entitys;

namespace ApiRestModeloDDD.Infrastructure.Data.Repositorys
{
    public class RepositoryCliente : RepositoryBase<Cliente>, IRepositoryCliente
    {
        private readonly ContextSql _contextSql;

        public RepositoryCliente(ContextSql contextSql)
            : base(contextSql)
        {
            this._contextSql = contextSql;
        }
    }
}