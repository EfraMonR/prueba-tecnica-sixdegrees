using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using CapaNegocio.Features.User.Queries.GetUsers;
using CapaNegocio.Contracts.Infraestructure;
using CapaAccesoDatos.Repositories;
using CapaNegocio;
using CapaAccesoDatos;

namespace BackendSixDegrees
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddApplicationServices(Configuration);
            services.AddPersistenceServices(Configuration);
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "BackendSixDegrees", Version = "v1" });
            });

            //Registrar MediatR
            //services.AddMediatR(typeof(Startup));

            //Registar automapper
            //services.AddAutoMapper(typeof(Startup));

            //Registrar repositorio
            //services.AddScoped(typeof(IAsyncRepository<>), typeof(BaseRepository<>));

            //Registrar el handler
            services.AddTransient<IRequestHandler<GetUserQuery, List<ResponseGetUserVm>>, GetUserQueryHandler>();

            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder
                        .AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader());
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "BackendSixDegrees v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            // Habilitar CORS
            app.UseCors("CorsPolicy");

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
