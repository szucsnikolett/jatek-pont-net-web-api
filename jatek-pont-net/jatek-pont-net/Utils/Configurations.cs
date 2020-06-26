using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using jatek_pont_net.Domain.Repositories;
using jatek_pont_net.Persistence;
using jatek_pont_net.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace jatek_pont_net.Utils
{
    public static class Configurations
    {
        public static void ConfigureDependencies(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IArRepository, ArRepository>();
        }

        public static void ConfigureSqlConnection(this IServiceCollection services)
        {
            services.AddDbContext<jatek_pont_netContext>(config =>
                config.UseSqlServer("Data Source=RAJ\\ROKA;Initial Catalog=jatek_pont_net;Integrated Security=True"));
        }
    }
}
