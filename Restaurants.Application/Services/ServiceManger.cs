using AutoMapper;
using Restaurants.Abstraction.Services;
using Restaurants.Domains.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurants.Application.Services
{
    public class ServiceManger : IServiceManger
    {
        // implement this service with lazy intialization
        private readonly Lazy<IRestaurantService> _restaurantService;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ServiceManger(IUnitOfWork unitOfWork , IMapper mapper)
        {
            _restaurantService = new Lazy<IRestaurantService>(new RestaurantService(_unitOfWork , _mapper));
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public IRestaurantService restaurantService => _restaurantService.Value;
    }
}
