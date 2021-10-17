using ApiRestModeloDDD.Domain.Core.Interfaces.Repositorys;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ApiRestModeloDDD.Infrastructure.Data.Repositorys
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        private readonly ContextSql _contextSql;

        public RepositoryBase(ContextSql contextSql)
        {
            this._contextSql = contextSql;
        }

        public void Add(TEntity obj)
        {
            try
            {
                _contextSql.Set<TEntity>().Add(obj);
                _contextSql.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _contextSql.Set<TEntity>().ToList();
        }

        public TEntity GetById(int id)
        {
            return _contextSql.Set<TEntity>().Find(id);
        }

        public void Remove(TEntity obj)
        {
            try
            {
                _contextSql.Set<TEntity>().Remove(obj);
                _contextSql.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(TEntity obj)
        {
            try
            {
                _contextSql.Entry(obj).State = EntityState.Modified;
                _contextSql.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}