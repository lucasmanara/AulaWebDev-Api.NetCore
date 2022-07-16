using AulaWebDev.Infra.Context;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaWebDev.Infra.Dependencias
{
    public static class InjecaoDependenciaExtension
    {
        public static IServiceCollection AddInfraestrutura(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("SqliteConnectionString");
            services.AddSqlite<AulaWebDevDbContext>(connectionString);

            return services;
        }
    }
}
