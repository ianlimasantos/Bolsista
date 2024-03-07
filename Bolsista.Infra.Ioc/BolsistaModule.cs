using Bolsista.Domain.Interfaces.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Bolsista.Infra.Data.Repositories;
using AutoMapper;
using Bolsista.Application.Mapper;

namespace Bolsista.Infra.Ioc
{
    public static class BolsistaModule
    {
        private static IServiceCollection ConfigureMapper(this IServiceCollection services)
        {
            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new DomainToViewProfile());
            });

            services.AddSingleton(mapperConfig.CreateMapper());
            return services;
        }
        public static IServiceCollection ConfigureDependencyInjection(this IServiceCollection services)
        {
            services.AddScoped<IBolsistaRepository, BolsistaRepository>();
            return services;
        }
    }
}
