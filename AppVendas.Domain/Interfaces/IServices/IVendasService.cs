using AppVendas.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppVendas.Domain.Interfaces.IServices
{
    public interface IVendasService : IDisposable
    {
        Vendas Adicionar(Vendas vendas);
        Vendas Atualizar(Vendas vendas);
        Vendas Remover(Vendas vendas);
    }
}
