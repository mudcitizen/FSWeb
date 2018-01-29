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
using FSWeb.Infrastructure.Routing;

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

                RoutingTemplateStringBuilder sb = new RoutingTemplateStringBuilder();
                sb.AddLiteral(RoutingConstants.Controller.Home);
                sb.Seperate();
                sb.AddLiteral(RoutingConstants.StaticText.Page);
                sb.AddParameter(RoutingConstants.ParameterName.Page);

                String txt = sb.ToString();
                routes.MapRoute(name: "pagination",
                template: sb.ToString(),
                defaults: new ControllerActionRouteSpecification() { Controller = RoutingConstants.Controller.Home, Action = RoutingConstants.Action.Index});

                sb = new RoutingTemplateStringBuilder();
                sb.AddController(RoutingConstants.Controller.Home);
                sb.Seperate();
                sb.AddAction(RoutingConstants.Action.Index);
                sb.Seperate();
                sb.AddParameter(RoutingConstants.ParameterName.Id + RoutingConstants.Terms.QuestionMark);
                txt = sb.ToString();
                routes.MapRoute(name: "default",
                template: sb.ToString());
            });

            FSContext context = app.ApplicationServices.GetRequiredService<FSContext>();
            DbInitializer.Initialize(context);

        }
    }
}
