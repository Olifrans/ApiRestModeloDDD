using System.Collections.Generic;

namespace ApiRestModeloDDD.Domain.Core.Interfaces.Services
{
    public interface IServiceBase<TEntity> where TEntity : class
    {
        void Add(TEntity obj);

        void Update(TEntity obj);

        void Remove(TEntity obj);

        IEnumerable<TEntity> GetAll(); //List ocupa mais memória -- IEnumerable mais perfomatico do que a List

        TEntity GetById(int id);
    }
}