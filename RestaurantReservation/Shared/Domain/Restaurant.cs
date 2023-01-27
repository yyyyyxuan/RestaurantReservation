using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReservation.Shared.Domain
{
    public class Restaurant : BaseDomainModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
    }
}
