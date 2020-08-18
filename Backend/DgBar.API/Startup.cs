using DgBar.Domain.Interfaces;
using DgBar.Domain.Services;
using DgBar.InfraData.Context;
using DgBar.InfraData.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System;

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


            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "Dg Bar",
                    Description = "Web Api DG Bar - This api is used for sales control",
                    Contact = new OpenApiContact
                    {
                        Name = "Thalita Mariano",
                        Email = "talita.hs.mariano@gmail.com",
                        Url = new Uri("https://github.com/marianohtl")
                    }
             
                });
            });

        }


        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();


            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("v1/swagger.json", "MyAPI V1");
            });
            
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {   
                endpoints.MapControllers();
            });
        }


    }
}
