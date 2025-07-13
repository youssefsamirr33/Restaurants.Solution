using Restaurants.Abstraction.DTOs.Restaurant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurants.Abstraction.Services
{
    public interface IRestaurantService
    {
        Task<IReadOnlyList<RestaurantDto>> GetRestaurantsAsync();
        Task<IReadOnlyList<TableDto>> GetTablesAsync();
        Task<int> CreateNewTableAsync(TableDto table);
    }
}
