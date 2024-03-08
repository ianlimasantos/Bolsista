using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolsista.Infra.Data.EF.Extensions
{
    public static class EntityFrameworkExtensions
    {
        public static IServiceCollection AddEFConfiguration(this IServiceCollection services,
            string connectionString)
        {
            services.AddEntityFrameworkSqlServer()
                .AddDbContext<BolsistaContext>(options =>
                {
                    options.UseSqlServer(connectionString);
                },
                ServiceLifetime.Scoped);
            return services;
        }
    }
}
