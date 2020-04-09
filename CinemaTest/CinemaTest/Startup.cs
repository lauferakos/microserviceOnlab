using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CinemaTest.AggregatesModel.OrderAggregate;
using CinemaTest.AggregatesModel.ProjectionAggregate;
using CinemaTest.AggregatesModel.ViewerAggregate;
using CinemaTest.Infrastructure;
using CinemaTest.Infrastructure.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace CinemaTest
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
            var server = Configuration["DBServer"] ?? "localhost";
            var port = Configuration["DBPort"] ?? "1433";
            var user = Configuration["DBUser"] ?? "SA";
            var password = Configuration["DBPassword"] ?? "A4s5dkw52+B!";
            var database = Configuration["Database"] ?? "SearchingDB";

            services.AddControllers();
            services.AddDbContext<SearchingContext>(options => 
            options.UseSqlServer($"Server={server},{port};Initial Catalog={database};User ID ={user};Password={password}"));
            services.AddTransient<IOrderRepository, OrderRepository>();
            services.AddTransient<IProjectionRepository, ProjectionRepository>();
            services.AddTransient<IViewerRepository, ViewerRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            
            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            SeedData.UpdateDatabase(app);
        }
    }
}
