
using Microsoft.EntityFrameworkCore;
using Restaurants.Api.Extentions;
using Restaurants.Infrastructure.Persistence;
using Restaurants.Infrastructure.Persistence.Data;

namespace Restaurants.Api
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            #region Service container
            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            // Add dependancy Injection container for application dbcontext
            builder.Services.AddRestaurantContextService(builder.Configuration);
            #endregion

            var app = builder.Build();

            #region DataBase Initializer and data seeding
            await app.Initializers(); 
            #endregion

            #region Configure middlware services
            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();



            // 1- Route match (url --> endpoint)
            // 2- generate the route table and set possible routes 
            // 3- when the route matched the endpoint an execution  ---> baseurl/api/controller/action
            app.MapControllers(); // determind the route for the route attribute for controllers or endpoints 
            #endregion

            app.Run();
        }
    }
}
