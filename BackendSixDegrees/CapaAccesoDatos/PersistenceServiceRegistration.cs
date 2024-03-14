using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoDatos.Repositories;
using CapaNegocio.Contracts.Infraestructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CapaAccesoDatos
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            //Variable de conexión que verifica el archivo appsettings.json en donde se encuentra la cadena de conexión.
            string configurationBD = configuration.GetConnectionString("DBConnectionPruebaSD");

            //Se conecta con base de datos.
            services.AddDbContext<PruebaSDDbContext>(options =>
                options.UseSqlServer(configurationBD,
                    builder => builder.EnableRetryOnFailure()));
            services.AddScoped(typeof(IAsyncRepository<>), typeof(BaseRepository<>));
            return services;
        }
    }
}
