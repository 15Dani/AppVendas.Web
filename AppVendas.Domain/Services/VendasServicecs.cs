using AppVendas.Domain.Entities;
using AppVendas.Domain.Interfaces.IRepositories;
using AppVendas.Domain.Interfaces.IServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppVendas.Domain.Services
{
   public class VendasServicecs : IVendasService
    {
        private readonly IVendasRepository _ivendasRepository;
        public VendasServicecs(IVendasRepository ivendasRepository)
        {
            _ivendasRepository = ivendasRepository;
        }

        public Vendas Adicionar(Vendas vendas)
        {
            _ivendasRepository.Adicionar(vendas);
            return vendas;
        }

        public Vendas Atualizar(Vendas vendas)
        {
            _ivendasRepository.Atualizar(vendas);
            return vendas;
        }

        public Vendas Remover(Vendas vendas)
        {
            _ivendasRepository.Remover(vendas);
            return vendas;
        }

        public void Dispose()
        {
            _ivendasRepository.Dispose();
        }
    }
}
