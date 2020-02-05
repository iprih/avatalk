using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Avanade.AvaTalk.Manager;
using Avanade.AvaTalk.Manager.Teste;
using Avanade.AvaTalk.Repository;
using Avanade.AvaTalk.Repository.Teste;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Avanade.AvaTalk.WebApi
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
            services.AddControllers();

            //Transient sempre cria uma instancia da classe quando chamada
            services.AddTransient<ITesteManager, TesteManager>();

            services.AddTransient<ITesteRepository, TesteRepository>();

            services.AddAutoMapper(typeof(Startup));

            //var config = new MapperConfiguration(cfg =>
            //{
            //    cfg.CreateMappings();
            //});

            //services.AddSingleton(config);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
