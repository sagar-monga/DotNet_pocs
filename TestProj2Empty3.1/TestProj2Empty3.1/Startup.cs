using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
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
        //* Logger outputs to debug console. SEE OUTPUT TO CHECK HOW REQUEST PROCESSING PIPELINE WORKS
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILogger<Startup> logger)
        {
            // Request pipeline using the extension method of the IapplicationBuilder interface
            if (env.IsDevelopment())
            {
                // middleware pipeline begins here
                // 1
                app.UseDeveloperExceptionPage();
            }

            //  Using a seperate file other than the default file as home page
            DefaultFilesOptions defaultFilesOptions = new DefaultFilesOptions();
            defaultFilesOptions.DefaultFileNames.Clear();
            defaultFilesOptions.DefaultFileNames.Add("home.html");
            // app.UseDefaultFiles(defaultFilesOptions);

            //* Order for following 2 middlewares is important
            // Middleware for using default.html/index.html as home page
            // app.UseDefaultFiles();

            // Middleware for static files - include this first
            // app.UseStaticFiles();

            // Instead of using the 2 middleware above, we can use them together as
            // Optional, setting path to a different page
            FileServerOptions fileServerOptions = new FileServerOptions();
            fileServerOptions.DefaultFilesOptions.DefaultFileNames.Clear();
            fileServerOptions.DefaultFilesOptions.DefaultFileNames.Add("home.html");

            app.UseFileServer();

            // 2
            app.UseRouting();

            // 3a
            app.Use(async (context, next) =>
            {
                logger.LogInformation("MW1: Incoming Request");
                await context.Response.WriteAsync($"From MW1\n");
                await next(); // Calls the next middleware, if this is commented, this becomes a TERMINAL middleware, ie not passes to next
                logger.LogInformation("MW1: Outgoing Response");
            });

            // 3b
            app.Use(async (context, next) =>
            {
                logger.LogInformation("MW2: Incoming Request");
                await context.Response.WriteAsync($"From MW2\n");
                await next(); // Calls the next middleware
                logger.LogInformation("MW2: Outgoing Response");
            });

            // 4
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    // Middleware which responds to EVERY Request!
                    await context.Response.WriteAsync($"Running on - {System.Diagnostics.Process.GetCurrentProcess().ProcessName}\n");
                    //! No output as there is no key found with name "Custom"
                    // await context.Response.WriteAsync($"Using env variable - {_configuration["Custom"]}");
                    await context.Response.WriteAsync($"Using env variable - {_configuration["CustomKey"]}");

                    logger.LogInformation("MW3: Request handled and response produced");
                });
                // To serve static files, they have to be in wwwrroot folder, hence creating one.
                // But serving them is not handled here
            });
        }
    }
}
