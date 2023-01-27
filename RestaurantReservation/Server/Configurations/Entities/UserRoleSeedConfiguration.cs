using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
namespace RestaurantReservation.Server.Configurations.Entities
{
    public class UserRoleSeedConfiguration :
    IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void
        Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
            new IdentityUserRole<string>
            {
                RoleId = "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                UserId = "3781efa7-66dc-47f0-860f-e506d04102e4"
            }
            );
            builder.HasData(
            new IdentityUserRole<string>
            {
                RoleId = "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                UserId = "ce2cf924-58d3-427f-813a-a6de6bc7400d"
            }
            );
            builder.HasData(
            new IdentityUserRole<string>
            {
                RoleId = "e660c1e1-9327-4b4a-a449-da5bb9547d0d",
                UserId = "12db73f8-0dd6-493b-b15d-6701880bf36e"
            }
            );
            
        }
    }
}