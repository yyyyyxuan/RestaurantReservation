using RestaurantReservation.Server.Data;
using RestaurantReservation.Server.IRepository;
using RestaurantReservation.Server.Models;
using RestaurantReservation.Shared.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace RestaurantReservation.Server.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private IGenericRepository<Reservation> _reservation;
        private IGenericRepository<Restaurant> _restaurant;
        private IGenericRepository<Spotlight> _spotlight;
        private IGenericRepository<SpotlightItem> _spotlightitem;
        

        private UserManager<ApplicationUser> _userManager;

        public UnitOfWork(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IGenericRepository<Reservation> Reservations
            => _reservation ??= new GenericRepository<Reservation>(_context);
        public IGenericRepository<Restaurant> Restaurants
            => _restaurant ??= new GenericRepository<Restaurant>(_context);
        public IGenericRepository<Spotlight> Spotlights
            => _spotlight ??= new GenericRepository<Spotlight>(_context);
        public IGenericRepository<SpotlightItem> SpotlightItems
            => _spotlightitem ??= new GenericRepository<SpotlightItem>(_context);
       

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save(HttpContext httpContext)
        {
            //To be implemented
            string user = "System";

            var entries = _context.ChangeTracker.Entries()
                .Where(q => q.State == EntityState.Modified ||
                    q.State == EntityState.Added);

            foreach (var entry in entries)
            {
                ((BaseDomainModel)entry.Entity).DateUpdated = DateTime.Now;
                ((BaseDomainModel)entry.Entity).UpdatedBy = user;
                if (entry.State == EntityState.Added)
                {
                    ((BaseDomainModel)entry.Entity).DateCreated = DateTime.Now;
                    ((BaseDomainModel)entry.Entity).CreatedBy = user;
                }
            }

            await _context.SaveChangesAsync();
        }
    }
}