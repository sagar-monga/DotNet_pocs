using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestProj2Empty3._1.Models;

namespace TestProj2Empty3._1
{
    public class Startup
    {
        private readonly IConfiguration _configuration;
        // Config read in following order
        // - Appsettings.json,
        // - appsetting.Env.json
        // - User Secrets
        // - Environment Variables
        // - Command line args

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc((options) => options.EnableEndpointRouting = false);
            // services.AddMvcCore((options) => options.EnableEndpointRouting = false);

            services.AddSingleton<IEmployeeRepository, MockEmployeeRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        //* Logger outputs to debug console. SEE OUTPUT TO CHECK HOW REQUEST PROCESSING PIPELINE WORKS
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILogger<Startup> logger)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // app.UseFileServer();
            app.UseStaticFiles();

            // Picks default route with this name : '{controller=Home}/{action=Index}/{id?}' i.e HomeController's INdex function. See definition of middleware
            // If HomeController's Index is defined, this becomes terminal middleware
            app.UseMvcWithDefaultRoute();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync($"Running on - {System.Diagnostics.Process.GetCurrentProcess().ProcessName}\n");
                    await context.Response.WriteAsync($"Using env variable - {_configuration["CustomKey"]}");
                });
            });
        }
    }
}
