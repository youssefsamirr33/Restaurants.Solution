using Microsoft.EntityFrameworkCore;
using Restaurants.Domains.Contract;
using Restaurants.Domains.Entities.Restaurant;
using System.Text.Json;

namespace Restaurants.Infrastructure.Persistence.Data
{
    public class DataBaseInitializer(RestaurantDbContext dbContext) : IDataBaseInitializer
    {
        public async Task IntializeAsync()
        {
            var penddingMigrations = await dbContext.Database.GetPendingMigrationsAsync();
            if (penddingMigrations.Any())
                await dbContext.Database.MigrateAsync(); // update-database 
        }

        public async Task SeedAsync()
        {
            if(dbContext.Restaurants.Count() == 0)
            {
                var restaurantData = await File.ReadAllTextAsync("../Restaurants.Infrastructure.Persistence/Data/DataSeeding/Restaurants.json");
                var restaurants = JsonSerializer.Deserialize<List<restaurant>>(restaurantData);

                if(restaurants?.Count > 0)
                {
                    await dbContext.Set<restaurant>().AddRangeAsync(restaurants);
                    await dbContext.SaveChangesAsync();
                }
                
            }

            if (dbContext.Tables.Count() == 0)
            {
                var tablesData = await File.ReadAllTextAsync("../Restaurants.Infrastructure.Persistence/Data/DataSeeding/Tables.json");
                var tables = JsonSerializer.Deserialize<List<table>>(tablesData);

                if (tables?.Count > 0)
                {
                    await dbContext.Set<table>().AddRangeAsync(tables);
                    await dbContext.SaveChangesAsync();
                }

            }
        }
    }
}
