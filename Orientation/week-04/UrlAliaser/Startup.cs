using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UrlAliaser.Database;
using UrlAliaser.Services;

namespace UrlAliaser
{
    public class Startup
    {
        private IConfiguration AppConfig { get; }

        public Startup(IConfiguration configuration)
        {
            AppConfig = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(options =>options.EnableEndpointRouting = false);
            ConfigureDb(services);
            services.AddTransient<DbService>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseMvc();
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });
            });
        }
        private void ConfigureDb(IServiceCollection services)
        {
            var connectionString = AppConfig.GetConnectionString("DefaultConnection");
            var serverVersion = new MySqlServerVersion(new Version(8, 0));

            services.AddDbContext<ApplicationDbContext>(
                options => options
                .UseMySql(connectionString, serverVersion)
                // The following three options help with debugging
                .LogTo(Console.WriteLine, LogLevel.Information)
                .EnableSensitiveDataLogging()
                .EnableDetailedErrors());
        }
    }
}
