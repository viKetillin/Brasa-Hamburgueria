using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using ApiCardapio.Models;
using ApiCardapio.Data;
using Microsoft.AspNetCore.Mvc.Controllers;
using System;

namespace ApiCardapio
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
            string conexao = Configuration.GetConnectionString("Conexao");
            services.AddDbContext<Contexto>(
                options => options.UseMySql(conexao, ServerVersion.AutoDetect(conexao))
            );
            services.AddCors();

            services.AddControllers().AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.PropertyNamingPolicy = null;
            }); 
            
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "ApiCardapio", Version = "v1" });

                //c.TagActionsBy(api =>
                //{
                //    if (api.GroupName != null)
                //    {
                //        return new[] { api.GroupName };
                //    }

                //    var controllerActionDescriptor = api.ActionDescriptor as ControllerActionDescriptor;
                //    if (controllerActionDescriptor != null)
                //    {
                //        return new[] { controllerActionDescriptor.ControllerName };
                //    }

                //    throw new InvalidOperationException("Unable to determine tag for endpoint.");
                //});
                //c.DocInclusionPredicate((name, api) => true);
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "ApiCardapio v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors(option => option.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
