namespace Restaurants.Abstraction.DTOs.Restaurant
{
    public class RestaurantDto
    {
        public required string Name { get; set; }
        public required string Address { get; set; }
        public required string City { get; set; }
        public required string state { get; set; }
        public required string Zip_Code { get; set; }
        public required string Country { get; set; }
        public required string phone { get; set; }
        public required string Email { get; set; }
        public required string WebSite { get; set; }
    }
}
