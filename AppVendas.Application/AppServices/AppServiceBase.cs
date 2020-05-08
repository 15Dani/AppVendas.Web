using System;
using System.Collections.Generic;
using System.Text;
using AppVendas.Domain.Interfaces.IUoW;

namespace AppVendas.Application.AppServices
{
    public abstract class AppServiceBase
    {
        private readonly IUnityOfWork _uow;

        protected AppServiceBase(IUnityOfWork uow)
        {
            _uow = uow;
        }

        protected void BeginTransaction()
        {
            _uow.BeginTransaction();
        }

        protected void RollBack()
        {
            _uow.RollBack();
        }

        protected void Commit()
        {
            _uow.Commit();
        }

        protected bool SaveChanges()
        {
            return _uow.SaveChanges();
        }

    }
}

    

