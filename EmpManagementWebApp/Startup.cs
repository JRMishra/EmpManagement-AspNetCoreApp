using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

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

            //FileServerOptions fileServerOptionsObj = new FileServerOptions();
            //fileServerOptionsObj.DefaultFilesOptions.DefaultFileNames.Clear();
            //fileServerOptionsObj.DefaultFilesOptions.DefaultFileNames.Add("food.html");
            //app.UseFileServer(fileServerOptionsObj);
            app.UseFileServer();

            app.Run(async(context) => {
                throw new Exception("Some error in processing the page");
                //await context.Response.WriteAsync("Employee Management Tool");
            });

        }
    }
}
