using Restaurants.Domains.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurants.Domains.Entities.Restaurant
{
    public class Tables : BaseAuditableEntity<int>
    {
        public string Table_Number { get; set; }
        public int Capacity { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public bool IsAviable { get; set; }


        public int restId { get; set; }
        public Restaurants restaurants { get; set; }  // navigational property 
    }
}
