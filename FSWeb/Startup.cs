using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FSWeb.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using FSWeb.Data.DAL;

namespace FSWeb
{
    public class Startup
    {
        
        IConfiguration Configuration { get; }

        public Startup(IConfiguration config)
        {
            Configuration = config;
        }
        
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            // Tells it how to get an FSContext - upon which the SqlRepository depends

            // Bad - 
            // String connStr = Configuration["DefaultConnection"];
            // Good .. 
            String connStr = Configuration["ConnectionStrings:DefaultConnection"];

            services.AddDbContext<FSContext>(options => options.UseSqlServer(connStr, o => o.MigrationsAssembly("FSWeb")));
            services.AddTransient<IRepository,SqlRepository>();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseMvc(routes => {
            routes.MapRoute(name: "default",
                template: "{controller=Home}/{action=Index}/{id?}");});
        }
    }
}
