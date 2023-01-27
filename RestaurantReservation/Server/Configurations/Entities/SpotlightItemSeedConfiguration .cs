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
                    ExpireDate = DateTime.Today,
                    RestaurantId = 1,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System",
                }
            );
        
           
        }
    }
}
