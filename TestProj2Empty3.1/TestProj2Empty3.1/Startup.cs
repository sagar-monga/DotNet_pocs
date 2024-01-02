using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                // Request pipeline using the extension method of the IapplicationBuilder interface

                // middleware pipeline begins here
                // 1
                app.UseDeveloperExceptionPage();
            }
            // 2
            app.UseRouting();
            // 3
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    // Middleware which responds to EVERY Request!
                    await context.Response.WriteAsync($"Running on - {System.Diagnostics.Process.GetCurrentProcess().ProcessName}\n");
                    //! No output as there is no key found with name "Custom"
                    // await context.Response.WriteAsync($"Using env variable - {_configuration["Custom"]}");
                    await context.Response.WriteAsync($"Using env variable - {_configuration["CustomKey"]}");
                });
                // To serve static files, they have to be in wwwrroot folder, hence creating one.
                // But serving them is not handled here
            });
        }
    }
}
