using RestaurantReservation.Shared.Domain;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantReservation.Server.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        Task Save(HttpContext httpContext);
        IGenericRepository<Restaurant> Restaurants { get; }
        IGenericRepository<Reservation> Reservations { get; }
        IGenericRepository<Spotlight> Spotlights { get; }
        IGenericRepository<SpotlightItem> SpotlightItems { get; }
    }
}