using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestaurantReservation.Shared.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantReservation.Server.Configurations.Entities
{
    public class SpotlightSeedConfiguration : IEntityTypeConfiguration<Spotlight>
    {
        public void Configure(EntityTypeBuilder<Spotlight> builder)
        {
            builder.HasData(
                new Spotlight {
                    Id = 1,
                    SpotlightHeader="Fast Food",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System",
                }
            );
        
           
        }
    }
}
