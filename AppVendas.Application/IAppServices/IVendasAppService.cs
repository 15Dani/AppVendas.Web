using System;
using System.Collections.Generic;
using System.Text;
using AppVendas.Application.Dto;

namespace AppVendas.Application.IAppServices
{
   public interface IVendasAppService : IDisposable
    {
        IEnumerable<VendasDto> ObterTodos();

        VendasDto ObterPorId(Guid id);

        VendasDto Adicionar(VendasDto vendasDto);

        void Editar(VendasDto vendasDto);

        void Deleter(Guid Id);



    }
}
