using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppVendas.Application.Dto;
using AppVendas.Application.IAppServices;
using AppVendas.Domain.Entities;
using AppVendas.Domain.Interfaces.IRepositories;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AppVendas.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class VendasController : ControllerBase
    {
        private readonly IVendasAppService _vendasAppService;
        private readonly IVendasRepository _ivendasRepository;
        private readonly IMapper _mapper;

        public VendasController(IVendasAppService vendasAppService, IVendasRepository ivendasRepository, IMapper mapper)
        {
            _vendasAppService = vendasAppService;
            _ivendasRepository = ivendasRepository;
            _mapper = mapper;
        }

        //Get api/Vendas
        [HttpGet]
        public ActionResult GetVendas()
        {
            try
            {
                var vendas = _ivendasRepository.ObterTodos();

                var results = _mapper.Map<VendasDto[]>(vendas);
                return Ok(results);
            }

            catch (System.Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, " Ocorreu uma falha ao acessar o banco de dados");
            }

        }

        [HttpPost]
        public ActionResult Post(VendasDto venda)
        {
            try
            {
                var vendas = _mapper.Map<Vendas>(venda);
                _ivendasRepository.Adicionar(vendas);
                if (_ivendasRepository.SaveChanges() > 0)
                {
                    return Created($"api/Vendas/{vendas.Id}", _mapper.Map<VendasDto>(vendas));
                }
            }
            catch (System.Exception e)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Ocorreu um falha ao acessar o banco de dados " + e.Message);
            }

            return StatusCode(StatusCodes.Status403Forbidden, $"Ocorreu um erro ao inserir {venda}");
        }
    }
}




