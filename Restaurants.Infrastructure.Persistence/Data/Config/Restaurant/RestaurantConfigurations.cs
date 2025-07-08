using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Restaurants.Domains.Entities.Restaurant;
using Restaurants.Infrastructure.Persistence.Data.Config.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurants.Infrastructure.Persistence.Data.Config.Restaurant
{
    internal class RestaurantConfigurations : BaseAuditableEntityConfigurations<restaurant, int>
    {
        public override void Configure(EntityTypeBuilder<restaurant> builder)
        {
            base.Configure(builder);
            builder.Property(r => r.Name).IsRequired().HasMaxLength(100);
            builder.Property(r => r.City).IsRequired().HasMaxLength(100);
            builder.Property(r => r.Address).IsRequired().HasMaxLength(100);
            builder.Property(r => r.state).IsRequired().HasMaxLength(100);
            builder.Property(r => r.phone).IsRequired().HasMaxLength(20);
            builder.Property(r => r.Zip_Code).IsRequired().HasMaxLength(100);
            builder.Property(r => r.Country).IsRequired().HasMaxLength(100);
        }
    }
}
