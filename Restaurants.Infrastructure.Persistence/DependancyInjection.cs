using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Restaurants.Domains.Contract;
using Restaurants.Infrastructure.Persistence.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurants.Infrastructure.Persistence
{
    public static class DependancyInjection
    {
        public static IServiceCollection AddRestaurantContextService(this IServiceCollection services , IConfiguration configuration)
        {
            services.AddDbContext<RestaurantDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("defaultConnection"));
            });

            // allow dependancy injection for dataBase Initializer in service container 
            services.AddScoped(typeof(IDataBaseInitializer), typeof(DataBaseInitializer));

            return services;
        }
    }
}
