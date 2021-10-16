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

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") !=null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataCadastro").IsModified = false;
                }
            }
            return base.SaveChanges();
        }
    }
}
