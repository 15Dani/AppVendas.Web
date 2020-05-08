using AppVendas.Application.AppServices;
using AppVendas.Application.IAppServices;
using AppVendas.Domain.Interfaces.IRepositories;
using AppVendas.Domain.Interfaces.IServices;
using AppVendas.Domain.Interfaces.IUoW;
using AppVendas.Domain.Services;
using AppVendas.Infra.Data.Context;
using AppVendas.Infra.Data.Repositories;
using AppVendas.Infra.Data.UoW;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AppVendas.Infra.IoC
{
    public class BootStrapper
    {
        public static void RegisterDbContext(IConfiguration configuration, IServiceCollection service)
        {

            service.AddDbContext<VendasContext>(options => options.UseLazyLoadingProxies().UseMySQL(configuration.GetConnectionString("WebVendas")), ServiceLifetime.Scoped);

        }

        public static void Register(IServiceCollection services)
        {


            
            //AppService
           services.AddScoped<IVendasAppService, VendasAppServices>();

            //Domain
            services.AddScoped<IVendasService, VendasServicecs>();

            //Infra Data
            services.AddScoped<IVendasRepository, VendasRepository>();
            services.AddScoped<IUnityOfWork, UnityOrWork>();
            services.AddScoped<VendasContext>();
        }

        public static void RegisterMappings(IServiceCollection services, IMapper mapper)
        {
            services.AddSingleton(mapper);
        }

    }
}

    

    

