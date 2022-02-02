using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace Web
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddTransient<ICatalogo, Catalogo>(); // injeção de depenência
            //services.AddTransient<IRelatorio, Relatorio>(); // injeção de dependência

            //services.AddScoped<ICatalogo, Catalogo>(); // injeção de dependência
            //services.AddScoped<IRelatorio, Relatorio>(); // injeção de dependência

            var catalogo = new Catalogo();

            services.AddSingleton<ICatalogo>(catalogo);
            services.AddSingleton<IRelatorio>(new Relatorio(catalogo));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, IServiceProvider serviceProvider)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            ICatalogo catalogo = serviceProvider.GetService<ICatalogo>(); // aqui está sendo usada a injeção de dependência
            IRelatorio relatorio = serviceProvider.GetService<IRelatorio>(); // aqui está sendo usada a injeção de dependência
            
            app.Run(async (context) =>
            {
                await relatorio.Imprimir(context);
            });
        }
    }
}
