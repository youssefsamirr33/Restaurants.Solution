using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Restaurants.Domains.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurants.Infrastructure.Persistence.Data.Config.Base
{
    internal class BaseAuditableEntityConfigurations<TEntity , TKey> : BaseEntityConfigurations<TEntity , TKey>
        where TEntity : BaseAuditableEntity<TKey>
        where TKey : IEquatable<TKey>   
    {
        public override void Configure(EntityTypeBuilder<TEntity> builder)
        {
            base.Configure(builder);
            builder.Property(b => b.CreateBy).HasMaxLength(50);
            builder.Property(b => b.ModifiedBy).HasMaxLength(50);
        }

    }
    
}
