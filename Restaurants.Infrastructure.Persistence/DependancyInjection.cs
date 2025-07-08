using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
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
            

            return services;
        }
    }
}
