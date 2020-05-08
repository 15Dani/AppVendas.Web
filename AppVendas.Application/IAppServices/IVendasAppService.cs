using System;
using System.Collections.Generic;
using System.Text;
using AppVendas.Application.Dto;

namespace AppVendas.Application.IAppServices
{
   public interface IVendasAppService : IDisposable
    {
        IEnumerable<VendasDto> ObterTodos();

        VendasDto ObterPorId(int id);

        VendasDto Adicionar(VendasDto vendasDto);

        void Editar(VendasDto vendasDto);

        void Deleter(int Id);



    }
}
