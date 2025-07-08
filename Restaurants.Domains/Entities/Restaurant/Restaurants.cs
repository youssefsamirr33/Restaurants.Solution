using Restaurants.Domains.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurants.Domains.Entities.Restaurant
{
    public class restaurant : BaseAuditableEntity<int>
    {
        public required string Name { get; set; }
        public required string Address { get; set; }
        public required string City { get; set; }
        public required string state { get; set; }
        public required string Zip_Code { get; set; }
        public required string Country { get; set; }
        public required string phone { get; set; }
        public required string Email { get; set; }
        public required string WebSite { get; set; }

    }
}
