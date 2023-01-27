using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestaurantReservation.Shared.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantReservation.Server.Configurations.Entities
{
    public class RestaurantSeedConfiguration : IEntityTypeConfiguration<Restaurant>
    {
        public void Configure(EntityTypeBuilder<Restaurant> builder)
        {
            builder.HasData(
                new Restaurant {
                    Id = 1,
                    Name = "TestRestaurant",
                    UserName = "Admin",
                    Category = "TestCategory",
                    Description = "TestDesc",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System",
                    UserId = "3781efa7-66dc-47f0-860f-e506d04102e4"
                }
            );
        
           
        }
    }
}
