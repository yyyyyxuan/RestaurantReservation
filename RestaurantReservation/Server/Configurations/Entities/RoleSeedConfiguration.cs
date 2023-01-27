using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace RestaurantReservation.Server.Configurations.Entities
{
    public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id = "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                    Name = "CustomerUser",
                    NormalizedName = "CUSTOMERUSER"
                }
            );
            builder.HasData(
            new IdentityRole
            {
                Id = "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                Name = "Administrator",
                NormalizedName = "ADMINISTRATOR"
            }
            );
            builder.HasData(
               new IdentityRole
               {
                   Id = "e660c1e1-9327-4b4a-a449-da5bb9547d0d",
                   Name = "RestaurantUser",
                   NormalizedName = "RESTAURANTUSER"
               }
           );
        }
    }
}