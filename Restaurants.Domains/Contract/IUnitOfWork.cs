using Restaurants.Domains.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurants.Domains.Contract
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        // 1- property for each and every repository --- false
        // 2- property for each and every repository but use get and remoce set ---- flase
        // 3- using lazy implementation --- true
        // -4 using data structure for create the repo  --- true

        IGenaricRepository<TEntity , TKey> GetRepository<TEntity , TKey> ()
            where TEntity : BaseEntity<TKey>
            where TKey : IEquatable<TKey>;

        Task<int> CompleteAsync();
    }
}
