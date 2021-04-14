using B3.Adapter;
using B3.Bordas.Adapter;
using B3.Bordas.Repositorio;
using B3.Context;
using B3.Repositorios;
using B3.Services;
using B3.UseCase;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B3
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
            services.AddEntityFrameworkNpgsql().AddDbContext<LocalDbContext>(opt => opt.UseNpgsql
            (Configuration.GetConnectionString("urlSquadra")));

            services.AddScoped<IAtivoService, AtivoService>();

            services.AddScoped<IAdicionarAtivoUseCase, AdicionarAtivoUseCase>();
            services.AddScoped<IAtualizarAtivoUseCase, AtualizarAtivoUseCase>();
            services.AddScoped<IRemoverAtivoUseCase, RemoverAtivoUseCase>();
            services.AddScoped<IRetornarAtivoPorIdUseCase, RetornarAtivoPorIdUseCase>();
            services.AddScoped<IRetornarListaAtivosUseCase, RetornarListaAtivosUseCase>();

            services.AddScoped<IRepositorioAtivos, RepositorioAtivos>();
            services.AddScoped<IAdicionarAtivoAdapter, AdicionarAtivoAdapter>();
            


            services.AddRazorPages();
           
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
