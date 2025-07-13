using Restaurants.Domains.Common;
using Restaurants.Domains.Contract;
using Restaurants.Infrastructure.Persistence.Data;
using Restaurants.Infrastructure.Persistence.Repositories;

namespace Restaurants.Infrastructure.Persistence.Unit_of_work
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly Dictionary<string, object> _repository;
        private readonly RestaurantDbContext _context;

        public UnitOfWork(RestaurantDbContext context)
        {
            _repository = new();
            _context = context;
        }

        public IGenaricRepository<TEntity, TKey> GetRepository<TEntity, TKey>()
            where TEntity : BaseEntity<TKey>
            where TKey : IEquatable<TKey>
        {
            var KeyName = typeof(TEntity).Name;
            if(_repository.ContainsKey(KeyName))
                return (IGenaricRepository<TEntity, TKey>) _repository[KeyName];
            // if not --> create object from genaric repo
            var repository = new GenaricRepository<TEntity, TKey>(_context);
            _repository.Add(KeyName, repository);
            return repository;
        }
        public async Task<int> CompleteAsync()
            => await _context.SaveChangesAsync();

        public async ValueTask DisposeAsync()
            => await _context.DisposeAsync();

        
    }
}
