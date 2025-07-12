using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurants.Domains.Contract
{
    public interface IDataBaseInitializer
    {
        Task IntializeAsync();
        Task SeedAsync();
    }
}
