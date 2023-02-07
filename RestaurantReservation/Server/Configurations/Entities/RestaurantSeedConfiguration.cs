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
                    Name = "Admin's Restaurant",
                    UserName = "Admin",
                    Category = "Food",
                    Description = "We sell food",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System",
                    UserId = "3781efa7-66dc-47f0-860f-e506d04102e4"
                }
            );
            builder.HasData(
                new Restaurant
                {
                    Id = 2,
                    Name = "Kentucky Fried Chicken",
                    UserName = "KFC",
                    Category = "Fast Food",
                    Description = "We sell fried chicken",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System",
                    UserId = "cdc39beb-763d-4764-8086-d3d2790f98fd"
                }
            );
            builder.HasData(
                new Restaurant
                {
                    Id = 3,
                    Name = "Mac Donalds",
                    UserName = "MACS",
                    Category = "Fast Food",
                    Description = "We sell burgers and fries",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System",
                    UserId = "d2e65d50-0175-40ae-b91d-449484f6623a"
                }
            );
            builder.HasData(
                new Restaurant
                {
                    Id = 4,
                    Name = "Subway",
                    UserName = "Subway",
                    Category = "Fast Food",
                    Description = "We sell sandwiches",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System",
                    UserId = "86c52720-1b0d-4f59-b660-9d04357e8653"
                }
            );
        }
    }
}
