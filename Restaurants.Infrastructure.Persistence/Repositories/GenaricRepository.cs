using Microsoft.EntityFrameworkCore;
using Restaurants.Domains.Common;
using Restaurants.Domains.Contract;
using Restaurants.Infrastructure.Persistence.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurants.Infrastructure.Persistence.Repositories
{
    public class GenaricRepository<TEntity, TKey>(RestaurantDbContext _context) : IGenaricRepository<TEntity, TKey>
        where TEntity : BaseEntity<TKey>
        where TKey : IEquatable<TKey>
    {


        public async Task<IReadOnlyList<TEntity>> GetAllAsync(bool WithTracking = false)
            => WithTracking ? await _context.Set<TEntity>().ToListAsync() : await _context.Set<TEntity>().AsNoTracking().ToListAsync();

        public async Task<TEntity?> GetAsync(TKey Id)
            => await _context.Set<TEntity>().FindAsync(Id);

        public async Task AddAsync(TEntity entity)
            => await _context.Set<TEntity>().AddAsync(entity);
        public void Update(TEntity entity)
            =>  _context.Set<TEntity>().Update(entity);

        public void Delete(TEntity entity)
            => _context.Set<TEntity>().Remove(entity);

    }
}
