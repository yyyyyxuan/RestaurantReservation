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
            builder.HasData(
            new IdentityUserRole<string>
            {
                RoleId = "e660c1e1-9327-4b4a-a449-da5bb9547d0d",
                UserId = "cdc39beb-763d-4764-8086-d3d2790f98fd"
            }
            );
            builder.HasData(
            new IdentityUserRole<string>
            {
                RoleId = "e660c1e1-9327-4b4a-a449-da5bb9547d0d",
                UserId = "d2e65d50-0175-40ae-b91d-449484f6623a"
            }
            );
            builder.HasData(
            new IdentityUserRole<string>
            {
                RoleId = "e660c1e1-9327-4b4a-a449-da5bb9547d0d",
                UserId = "86c52720-1b0d-4f59-b660-9d04357e8653"
            }
            );
            builder.HasData(
            new IdentityUserRole<string>
            {
                RoleId = "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                UserId = "d5de43ef-33a1-48c2-ac88-b2d9b4ef6d49"
            }
            );
            builder.HasData(
            new IdentityUserRole<string>
            {
                RoleId = "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                UserId = "63320eb6-1c7b-439e-9e4f-99b47a240472"
            }
            );
        }
    }
}