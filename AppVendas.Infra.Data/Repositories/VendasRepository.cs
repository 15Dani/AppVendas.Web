using System;
using System.Collections.Generic;
using System.Text;
using AppVendas.Domain.Entities;
using AppVendas.Domain.Interfaces.IRepositories;
using AppVendas.Infra.Data.Context;

namespace AppVendas.Infra.Data.Repositories
{
   public class VendasRepository : RepositoryBase<Vendas>, IVendasRepository
    {
        public VendasRepository(VendasContext context) : base(context)
        {

        }
    }
}
