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
            string configurationBD = configuration.GetConnectionString("DBConnectionPruebaSD");
            services.AddDbContext<PruebaSDDbContext>(options =>
                options.UseSqlServer(configurationBD,
                    builder => builder.EnableRetryOnFailure()));
            services.AddScoped(typeof(IAsyncRepository<>), typeof(BaseRepository<>));
            return services;
        }
    }
}
