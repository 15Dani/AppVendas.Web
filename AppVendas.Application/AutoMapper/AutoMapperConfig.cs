using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using AppVendas.Application.Dto;
using AppVendas.Domain.Entities;

namespace AppVendas.Application.AutoMapper
{
    public class AutoMapperConfig
    {
        public static IMapper RegisterMappings()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Vendas, VendasDto>().ReverseMap();

            });

            IMapper mapper = config.CreateMapper();
            return mapper;
        }
    }
}