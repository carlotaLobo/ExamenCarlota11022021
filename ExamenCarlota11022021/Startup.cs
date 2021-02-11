using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExamenCarlota11022021.Data;
using ExamenCarlota11022021.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace MvcCore
{
    public class Startup
    {
        IConfiguration configuration;

        public Startup(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
       
        public void ConfigureServices(IServiceCollection services)
        {
            String cadena = this.configuration.GetConnectionString("sql");
            services.AddSession(options=>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(15);
            } );
            services.AddDbContext<Context>(options=> options.UseSqlServer(cadena));
            services.AddTransient<IRepository, Repository>();
            services.AddControllersWithViews();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseStaticFiles();
            app.UseSession();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}"
                );
            });
        }
    }
}
