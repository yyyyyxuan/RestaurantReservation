using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestaurantReservation.Shared.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantReservation.Server.Configurations.Entities
{
    public class SpotlightItemSeedConfiguration : IEntityTypeConfiguration<SpotlightItem>
    {
        public void Configure(EntityTypeBuilder<SpotlightItem> builder)
        {
            builder.HasData(
                new SpotlightItem {
                    Id = 1,
                    SpotlightId = 1,
                    ExpireDate = new DateTime(2023,03,12),
                    RestaurantId = 2,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System",
                }
            );
            builder.HasData(
                new SpotlightItem
                {
                    Id = 2,
                    SpotlightId = 1,
                    ExpireDate = new DateTime(2023, 01, 01),
                    RestaurantId = 3,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System",
                }
            );
            builder.HasData(
                new SpotlightItem
                {
                    Id = 3,
                    SpotlightId = 1,
                    ExpireDate = new DateTime(2023, 03, 14),
                    RestaurantId = 4,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System",
                }
            );

        }
    }
}
