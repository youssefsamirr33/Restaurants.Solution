using AutoMapper;
using Restaurants.Abstraction.DTOs.Restaurant;
using Restaurants.Domains.Entities.Restaurant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurants.Application.Mapping
{
    internal class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<restaurant, RestaurantDto>();
            CreateMap<table, TableDto>()
                .ForMember(d => d.restaurants, O => O.MapFrom(r => r.restaurants.Name));
        }
    }
}
