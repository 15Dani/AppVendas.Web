using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using AppVendas.Application.Dto;
using AppVendas.Application.IAppServices;
using AppVendas.Domain.Entities;
using AppVendas.Domain.Interfaces.IRepositories;
using AppVendas.Domain.Interfaces.IServices;
using AppVendas.Domain.Interfaces.IUoW;
using AppVendas.Domain.Services;

namespace AppVendas.Application.AppServices
{
    public class VendasAppServices : AppServiceBase, IVendasAppService
    {
        private readonly IVendasService _vendasService;
        private readonly IVendasRepository _vendasRepository;
        private readonly IMapper _mapper;

        public VendasAppServices(IVendasService vendasService, IVendasRepository vendasRepository, IUnityOfWork unityOrWork ,IMapper mapper) : base(unityOrWork)
        {

            _vendasService = vendasService;
            _vendasRepository = vendasRepository;
            _mapper = mapper;
        }

        public IEnumerable<VendasDto> ObterTodos()
        {
            return _mapper.Map<IEnumerable<VendasDto>>(_vendasRepository.ObterTodos());
        }

        public VendasDto ObterPorId(int id)
        {
            return _mapper.Map<VendasDto>(_vendasRepository.ObterPorId(id));
        }

        public VendasDto Adicionar(VendasDto vendasDto)
        {
            var vendas = _mapper.Map<Vendas>(vendasDto);
            vendas = _vendasService.Adicionar(vendas);

            if (!SaveChanges())
            {
                throw new Exception();
            }

            return _mapper.Map<VendasDto>(vendas);

        }
    

        public void Editar (VendasDto vendasDto)
        {
            var vendasEditada = _mapper.Map<Vendas>(vendasDto);
            var vendas = _vendasRepository.ObterPorId(vendasDto.Id);

           // vendas.AtualizarDados(vendasEditada);

            vendas = _vendasService.Atualizar(vendas);

            if (!SaveChanges())
            {
                throw new Exception();
            }
        }

        public void Deleter (int Id)
        {
            var vendas = _vendasRepository.ObterPorId(Id);

            vendas = _vendasService.Remover(vendas);

            if (!SaveChanges())
            {
                throw new Exception();
            }
        }

        public void Dispose()
        {
            _vendasRepository.Dispose();
        }

    }
}
