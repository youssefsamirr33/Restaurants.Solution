using Restaurants.Domains.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurants.Domains.Entities.Restaurant
{
    public class Restaurant : BaseAuditableEntity<int>
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string state { get; set; }
        public string Zip_Code { get; set; }
        public string Country { get; set; }
        public string phone { get; set; }
        public string Email { get; set; }
        public string WebSite { get; set; }

    }
}
