using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantReservation.Client.Static
{
    public static class Endpoints
    {
        private static readonly string Prefix = "api";

        public static readonly string RestaurantEndpoint = $"{Prefix}/restaurants";
        public static readonly string ReservationEndpoint = $"{Prefix}/reservations";
        public static readonly string SpotlightEndpoint = $"{Prefix}/spotlights";
        public static readonly string SpotlightItemEndpoint = $"{Prefix}/spotlightitems";
        public static readonly string AccountsEndpoint = $"{Prefix}/accounts";
    }
}
