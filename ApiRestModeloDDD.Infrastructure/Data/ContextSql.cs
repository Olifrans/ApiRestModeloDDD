using ApiRestModeloDDD.Domain.Entitys;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiRestModeloDDD.Infrastructure.Data
{
    public class ContextSql : DbContext
    {
        public ContextSql()
        {                
        }

        public ContextSql(DbContextOptions<ContextSql> options) : base(options)
        {
        }

        public DbSet<Cliente> Cliente { get; set; }

        public DbSet<Produto> Produto { get; set; }

        public override SaveChanges()
        {
            foreach (var item in collection)
            {

            }
            return SaveChanges();
        }
    }
}
