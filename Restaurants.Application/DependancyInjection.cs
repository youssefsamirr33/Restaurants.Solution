using Microsoft.Extensions.DependencyInjection;
using Restaurants.Application.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurants.Application
{
    public static class DependancyInjection
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddAutoMapper(m => m.AddProfile(new MappingProfile()));
      
            return services;
        }
    }
}
