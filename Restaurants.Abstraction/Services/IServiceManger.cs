using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurants.Abstraction.Services
{
    public interface IServiceManger
    {
        public IRestaurantService restaurantService { get; }
    }
}
