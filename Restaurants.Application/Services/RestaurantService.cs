using AutoMapper;
using Restaurants.Abstraction.DTOs.Restaurant;
using Restaurants.Abstraction.Services;
using Restaurants.Domains.Contract;
using Restaurants.Domains.Entities.Restaurant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurants.Application.Services
{
    internal class RestaurantService(IUnitOfWork _unitOfWork , IMapper mapper) : IRestaurantService
    {

        public async Task<IReadOnlyList<RestaurantDto>> GetRestaurantsAsync()
        {
            var restaurants = await _unitOfWork.GetRepository<restaurant, int>().GetAllAsync();
            var restaurantsToResturn = mapper.Map<IReadOnlyList<RestaurantDto>>(restaurants);
            return restaurantsToResturn;
            
        }

        public async Task<IReadOnlyList<TableDto>> GetTablesAsync()
        {
            var rest = await _unitOfWork.GetRepository<table, int>().GetAllAsync();
            var RestToReturn = mapper.Map<IReadOnlyList<TableDto>>(rest);
            return RestToReturn;
        }
        public async Task<int> CreateNewTableAsync(TableDto table)
        {
            var MappingTable = mapper.Map<table>(table);
            await _unitOfWork.GetRepository<table, int>().AddAsync(MappingTable);

            return await _unitOfWork.CompleteAsync();

        }

    }
}
