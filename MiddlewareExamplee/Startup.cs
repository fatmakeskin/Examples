using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using MiddlewareExamplee.Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiddlewareExamplee
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
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "MiddlewareExamplee", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage(); // herhangi bir hata al�nd�g�nda exception page kullan�l�p kullan�lmayacag�n� anlat�r.
                
                //Swagger ile ilgili k�t�phaneyi cag�r�r daha sonras�nda ui k�sm�n� yani panelini �n�m�ze sunar                
                app.UseSwagger(); 
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "MiddlewareExamplee v1"));
            }

            app.Use(async (context, task) =>
            {
                Console.WriteLine("Use metodu baslad�");
                await task.Invoke();
                Console.WriteLine("Use metodu sona erdi");
            });

            //app.Map("/weatherforecast", builder =>
            //{
            //    builder.Run(async c => await c.Response.WriteAsync("Run middleware tetiklendi"));
            //});

            //app.Map("/home", builder =>
            //{
            //    builder.Use(async (context, task) =>
            //    {
            //        Console.WriteLine("Use metodu baslad�");
            //        await task.Invoke();
            //        Console.WriteLine("Use metodu sona erdi");
            //    });
            //});

            //app.Run(async context =>
            //{
            //    Console.WriteLine("Run metdou tetiklendi!!");
            //});


            app.UseHello();

            app.UseRouting(); //rout i�lemlerinde gelen rotan�n bize ayr�lmas�n� saglar.

            app.UseAuthorization(); //kullan�c� yetkilerini check eden bi middleware

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
