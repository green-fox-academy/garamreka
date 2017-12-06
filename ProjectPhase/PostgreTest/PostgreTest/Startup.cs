using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using PostgreTest.Entities;
using PostgreTest.Repositories;
using Microsoft.EntityFrameworkCore;
using System.IO;

namespace PostgreTest
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            //var connectionString =
            //    @"Server=127.0.0.1;Port=5432;Database=reka;User Id=postgres;Password=garamreka;";

            var connectionString = Environment.GetEnvironmentVariable("PostgreConnectionString", EnvironmentVariableTarget.User);

            services.AddMvc();
            services.AddDbContext<PGContext>(options => options.UseNpgsql(connectionString));
            services.AddScoped<PGRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });
        }
    }
}
