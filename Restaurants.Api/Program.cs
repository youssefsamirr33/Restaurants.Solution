
namespace Restaurants.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            #region Service container
            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(); 
            #endregion

            var app = builder.Build();

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
