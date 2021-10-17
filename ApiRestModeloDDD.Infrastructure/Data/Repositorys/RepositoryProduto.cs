using ApiRestModeloDDD.Domain.Core.Interfaces.Repositorys;
using ApiRestModeloDDD.Domain.Entitys;

namespace ApiRestModeloDDD.Infrastructure.Data.Repositorys
{
    public class RepositoryProduto : RepositoryBase<Produto>, IRepositoryProduto
    {
        private readonly ContextSql _contextSql;

        public RepositoryProduto(ContextSql contextSql)
            : base(contextSql)
        {
            this._contextSql = contextSql;
        }
    }
}