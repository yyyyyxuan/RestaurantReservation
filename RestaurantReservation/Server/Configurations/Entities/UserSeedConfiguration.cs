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
            builder.HasData(
            new ApplicationUser
            {
                Id = "cdc39beb-763d-4764-8086-d3d2790f98fd",
                Email = "kfc@localhost.com",
                NormalizedEmail = "KFC@LOCALHOST.COM",
                UserName = "KFC",
                NormalizedUserName = "KFC@LOCALHOST.COM",
                PasswordHash = hasher.HashPassword(null, "P@ssword1")
            }
            );
            builder.HasData(
            new ApplicationUser
            {
                Id = "d2e65d50-0175-40ae-b91d-449484f6623a",
                Email = "macs@localhost.com",
                NormalizedEmail = "MACS@LOCALHOST.COM",
                UserName = "MACS",
                NormalizedUserName = "MACS@LOCALHOST.COM",
                PasswordHash = hasher.HashPassword(null, "P@ssword1")
            }
            );
            builder.HasData(
            new ApplicationUser
            {
                Id = "86c52720-1b0d-4f59-b660-9d04357e8653",
                Email = "subway@localhost.com",
                NormalizedEmail = "SUBWAY@LOCALHOST.COM",
                UserName = "Subway",
                NormalizedUserName = "SUBWAY@LOCALHOST.COM",
                PasswordHash = hasher.HashPassword(null, "P@ssword1")
            }
            );
            builder.HasData(
            new ApplicationUser
            {
                Id = "d5de43ef-33a1-48c2-ac88-b2d9b4ef6d49",
                Email = "John@localhost.com",
                NormalizedEmail = "JOHN@LOCALHOST.COM",
                UserName = "John",
                NormalizedUserName = "JOHN@LOCALHOST.COM",
                PasswordHash = hasher.HashPassword(null, "P@ssword1")
            }
            );
            builder.HasData(
            new ApplicationUser
            {
                Id = "63320eb6-1c7b-439e-9e4f-99b47a240472",
                Email = "Peter@localhost.com",
                NormalizedEmail = "PETER@LOCALHOST.COM",
                UserName = "Peter",
                NormalizedUserName = "PETER@LOCALHOST.COM",
                PasswordHash = hasher.HashPassword(null, "P@ssword1")
            }
            );
        }
    }
}