using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace RestaurantReservation.Client.Model
{
    public class AppUser
    {
        public string PhoneNumber { get; set; }
        public string NormalizedEmail { get; set; }
        public string Email { get; set; }
        public string NormalizedUserName { get; set; }
        public string UserName { get; set; }
        public string Id { get; set; }
    }
}
//End of Code