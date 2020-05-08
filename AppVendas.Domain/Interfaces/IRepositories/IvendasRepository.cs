using AppVendas.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppVendas.Domain.Interfaces.IRepositories
{
   public interface IVendasRepository : IRepositoryRead<Vendas>, IRepositoryWrite<Vendas>
    {

    }
}
