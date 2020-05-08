using AppVendas.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppVendas.Domain.Interfaces.IRepositories
{
    public interface IRepositoryWrite<TEntity> : IDisposable where TEntity : EntityBase
    {
        void Adicionar(TEntity obj);

        void Atualizar(TEntity obj);

        void Remover(TEntity obj);

        int SaveChanges();

    }
}
