using Application.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    public static class PersistenceDI
    {
        public static void AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<IrisFlowerContext>(options => options.UseSqlServer(configuration.GetConnectionString("My connection"), b => b.MigrationsAssembly(typeof(IrisFlowerContext).Assembly.FullName)));
            services.AddScoped<IApplicationContext>(provider => provider.GetService<IrisFlowerContext>());
        }
    }
}
