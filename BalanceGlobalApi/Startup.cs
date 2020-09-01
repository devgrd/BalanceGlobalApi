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
            services.AddControllers();

            services.AddDbContext<BalanceGlobalContext>(opts => opts.UseSqlServer(Configuration.GetConnectionString("BalanceGlobalContext")));

            services.AddTransient<IService, Service>();

            services.AddTransient<IDatabaseFactory, DatabaseFactory>();
            services.AddTransient<IPeriodoRepository, PeriodoReposirory>();
            services.AddTransient<ISistemasRepository, SistemasRepository>();
            services.AddTransient<ISubSistemasRepository, SubSistemasRepository>();

            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

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
