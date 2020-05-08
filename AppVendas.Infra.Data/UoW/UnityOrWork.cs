using System;
using System.Collections.Generic;
using System.Text;
using AppVendas.Domain.Interfaces.IUoW;
using AppVendas.Infra.Data.Context;

namespace AppVendas.Infra.Data.UoW
{
    public class UnityOrWork : IUnityOfWork
    {
        private readonly VendasContext _context;

        public UnityOrWork(VendasContext context)
        {
            _context = context;
        }

        public void BeginTransaction()
        {
            _context.Database.BeginTransaction();
        }

        public void Commit()
        {
            _context.Database.CurrentTransaction.Commit();
        }

        public void RollBack()
        {
            _context.Database.CurrentTransaction.Rollback();
        }

        public bool SaveChanges()
        {
            return _context.SaveChanges() > 0;
        }
    }
}
