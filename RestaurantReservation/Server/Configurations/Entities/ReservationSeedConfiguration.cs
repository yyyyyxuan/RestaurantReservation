using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestaurantReservation.Shared.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantReservation.Server.Configurations.Entities
{
    public class ReservationSeedConfiguration : IEntityTypeConfiguration<Reservation>
    {
        public void Configure(EntityTypeBuilder<Reservation> builder)
        {
            builder.HasData(
                new Reservation
                {
                    Id = 1,
                    Pax = "3",
                    UserName = "John",
                    RestaurantId = 2,
                    ReservationDate = new DateTime(2023,01,01),
                    TimeSlot = "1400-1600",
                    RestaurantName = "Kentucky Fried Chicken",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System",
                    UserId = "d5de43ef-33a1-48c2-ac88-b2d9b4ef6d49"
                }
            );
            builder.HasData(
                 new Reservation
                 {
                     Id = 2,
                     Pax = "4",
                     UserName = "Peter",
                     RestaurantId = 3,
                     ReservationDate = new DateTime(2023, 04, 03),
                     TimeSlot = "1200-1400",
                     RestaurantName = "Mac Donalds",
                     DateCreated = DateTime.Now,
                     DateUpdated = DateTime.Now,
                     CreatedBy = "System",
                     UpdatedBy = "System",
                     UserId = "63320eb6-1c7b-439e-9e4f-99b47a240472"
                 }
             );

        }
    }
}
