using AppVendas.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppVendas.Domain.Interfaces.IRepositories
{
   public interface IRepositoryRead<TEntity> : IDisposable where TEntity : EntityBase
    {
        TEntity ObterPorId(Guid id);

        IEnumerable<TEntity> ObterTodos();
    }
}
