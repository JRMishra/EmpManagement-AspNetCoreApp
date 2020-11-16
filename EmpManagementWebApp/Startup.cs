using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using EmpManagementWebApp.Models;

namespace EmpManagementWebApp
{
    public class Startup
    {
        public IConfiguration _config;

        public Startup(IConfiguration configuration)
        {
            _config = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(options => options.EnableEndpointRouting= false);
            services.AddSingleton<IEmployeeRepo, MockEmployeeRepo>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                DeveloperExceptionPageOptions developerExceptionOptions = new DeveloperExceptionPageOptions();
                developerExceptionOptions.SourceCodeLineCount = 1;
                app.UseDeveloperExceptionPage(developerExceptionOptions);
            }
            else if(env.IsStaging() || env.IsProduction() || env.IsEnvironment("Custom"))
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseStaticFiles();

            //app.UseMvcWithDefaultRoute();
            //app.UseMvc(routes => {
            //    routes.MapRoute("default", "{controller=Home}/{action=Index}/{id?}");
            //});

            app.UseMvc();

            app.Run(async (context) =>
            {
                //throw new Exception("Custom exception");
                await context.Response.WriteAsync("Employee Management Tool");
            });

        }
    }
}
