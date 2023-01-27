using RestaurantReservation.Server.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace RestaurantReservation.Server.Configurations.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            var hasher = new PasswordHasher<ApplicationUser>();
            builder.HasData(
            new ApplicationUser
            {
                Id = "3781efa7-66dc-47f0-860f-e506d04102e4",
                Email = "admin@localhost.com",
                NormalizedEmail = "ADMIN@LOCALHOST.COM",
                UserName = "Admin",
                NormalizedUserName = "ADMIN@LOCALHOST.COM",
                PasswordHash = hasher.HashPassword(null, "P@ssword1")
            }
            );
            builder.HasData(
            new ApplicationUser
            {
                Id = "12db73f8-0dd6-493b-b15d-6701880bf36e",
                Email = "restaurant@localhost.com",
                NormalizedEmail = "RESTAURANT@LOCALHOST.COM",
                UserName = "restauranttestuser",
                NormalizedUserName = "RESTAURANT@LOCALHOST.COM",
                PasswordHash = hasher.HashPassword(null, "P@ssword1")
            }
            );
            builder.HasData(
            new ApplicationUser
            {
                Id = "ce2cf924-58d3-427f-813a-a6de6bc7400d",
                Email = "customer@localhost.com",
                NormalizedEmail = "CUSTOMER@LOCALHOST.COM",
                UserName = "customertestuser",
                NormalizedUserName = "CUSTOMER@LOCALHOST.COM",
                PasswordHash = hasher.HashPassword(null, "P@ssword1")
            }
            );
            
        }
    }
}