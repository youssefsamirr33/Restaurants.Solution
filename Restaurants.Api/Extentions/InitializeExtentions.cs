using Restaurants.Domains.Contract;
using Restaurants.Infrastructure.Persistence.Data;

namespace Restaurants.Api.Extentions
{
    public static class InitializeExtentions
    {
        public static async Task<WebApplication> Initializers(this WebApplication app)
        {
            var scoped = app.Services.CreateAsyncScope();
            var services = scoped.ServiceProvider; // used to resolve dependancies
            var dbInitializer = services.GetRequiredService<IDataBaseInitializer>();
            var loggerFactory = services.GetRequiredService<ILoggerFactory>();

            try
            {
                await dbInitializer.IntializeAsync();
                await dbInitializer.SeedAsync();
            }
            catch (Exception ex)
            {
                var logger = loggerFactory.CreateLogger<Program>();
                logger.LogError(ex, "An Error has been ocured when apply migration");
            }

            return app;
        }
    }
}
