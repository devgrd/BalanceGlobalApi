using BalanceGlobal.Api.Extensions;
using BalanceGlobal.Api.Middleware;
using BalanceGlobal.Api.Settings;
using BalanceGlobal.Database.Context;
using BalanceGlobal.Infrastructure;
using BalanceGlobal.Repository;
using BalanceGlobal.Service;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace BalanceGlobalApi
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
            services.AddControllers()
            .AddNewtonsoftJson(options =>
            {
                options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
                options.SerializerSettings.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;
            });


            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Balance Global API", Version = "v1" });
            });

            services.AddSwaggerGenNewtonsoftSupport();

            services.AddContext<BalanceGlobalContext>(Configuration, "BalanceGlobalContext");
            services.AddServices();

            //services.AddTransient<IService, Service>();

            //services.AddTransient<IDatabaseFactory, DatabaseFactory>();
            //services.AddTransient<IPeriodoRepository, PeriodoReposirory>();
            //services.AddTransient<ISistemasRepository, SistemasRepository>();
            //services.AddTransient<ISubSistemasRepository, SubSistemasRepository>();

            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Balance Global API V1");
            });

            app.UseMiddleware<BasicAuthMiddleware>();

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
