using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DgBar.Domain.Entities;
using DgBar.Domain.Interfaces;
using DgBar.Domain.Services;
using DgBar.InfraData.Context;
using DgBar.InfraData.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace DgBar.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddDbContext<BarDGContext>();
            services.AddScoped<IOrderManageService, OrderManageService>();
            services.AddScoped<IMenuRepository, MenuRepository>();
            services.AddScoped<IOrderSheetRepository, OrderSheetRepository>();
        }


        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {   
                endpoints.MapControllers();
            });
        }


    }
}
