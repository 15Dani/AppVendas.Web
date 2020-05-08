using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Crypto.Engines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AppVendas.Infra.Data.Context;
using AppVendas.Domain.Interfaces.IRepositories;
using AppVendas.Domain.Entities;

namespace AppVendas.Infra.Data.Repositories
{
    public class RepositoryBase<TEntity> : IRepositoryRead<TEntity>, IRepositoryWrite<TEntity> where TEntity : EntityBase, new()
    {
        protected VendasContext Db;
        protected DbSet<TEntity> DbSet;

        protected RepositoryBase(VendasContext Context)
        {
            Db = Context;
            DbSet = Db.Set<TEntity>();
        }

        public virtual void Adicionar(TEntity obj)
        {
            DbSet.Add(obj);
        }

        public virtual void Atualizar(TEntity obj)
        {
            var entry = Db.Entry(obj);
            DbSet.Attach(obj);
            entry.State = EntityState.Modified;
        }

        public virtual IEnumerable<TEntity> ObterTodos()
        {
            return DbSet.ToList();
        }
        public virtual TEntity ObterPorId(Guid id)
        {
            return DbSet.Find(id);
        }
        public int SaveChanges()
        {
            return Db.SaveChanges();
            //return SaveChanges();
        }

        public void Dispose()
        {
            Db.Dispose();
            GC.SuppressFinalize(this);
        }

        public virtual void Remover(Guid  id)
        {
            var entity = new TEntity { Id = id };
            Remover(entity);
        }
        public virtual void Remover(TEntity obj)
        {
            DbSet.Remove(obj);
        }
    }
}

    

