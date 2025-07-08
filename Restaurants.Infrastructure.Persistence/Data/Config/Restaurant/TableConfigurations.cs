using Microsoft.EntityFrameworkCore;
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
    internal class TableConfigurations : BaseAuditableEntityConfigurations<table , int>
    {
        public override void Configure(EntityTypeBuilder<table> builder)
        {
            base.Configure(builder);
            builder.Property(t => t.Table_Number).IsRequired();
            builder.Property(t => t.Location).IsRequired().HasMaxLength(100);
            builder.Property(t => t.Description).IsRequired().HasMaxLength(100);

            builder.HasOne(r => r.restaurants)
                .WithMany()
                .HasForeignKey(r => r.restId)
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
