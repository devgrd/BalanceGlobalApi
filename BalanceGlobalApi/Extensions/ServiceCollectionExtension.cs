
using BalanceGlobal.Database.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Reflection;

namespace BalanceGlobal.Api.Extensions
{
    public static  class ServiceCollectionExtension
    {

        public static IServiceCollection AddContext<T>(this IServiceCollection services, IConfiguration configuration, string connectionString) where T : DbContext
        {
            services.AddDbContext<T>(opts => opts.UseSqlServer(configuration.GetConnectionString(connectionString)));
            return services;
        }
        
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            Assembly Assemblies = Assembly.Load("BalanceGlobal");
            var list = Assemblies.GetTypes()
                .Where(x => (x.Namespace == "BalanceGlobal.Repository" 
                || x.Namespace == "BalanceGlobal.Service") 
                && x.IsClass 
                && x.IsNested == false);

            foreach (Type type in list)
            {
                var interfaceType = Type.GetType($"{type.Namespace}.I{type.Name},{type.Assembly.FullName}");
                var classType = Type.GetType($"{type.FullName}, {type.Assembly.FullName}");

                services.AddTransient(interfaceType, classType);
            }

            return services;
        }
    }
}
