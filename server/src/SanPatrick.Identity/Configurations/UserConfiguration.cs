using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SanPatrick.Identity.Models;

namespace SanPatrick.Identity.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            var hasher = new PasswordHasher<ApplicationUser>();

            builder.HasData(new ApplicationUser
            {
                Id = "383a363b-fa7e-4f40-9727-9aec581f3901",
                Email = "basic@mail.com",
                NormalizedEmail = "basic@mail.com",
                UserName = "client",
                NormalizedUserName = "client",
                PasswordHash = hasher.HashPassword(null, "12345"),
                PhoneNumber = "7352096019",
                FirstName = "Jose",
                MiddleName = "Luis",
                LastName = "Sandoval",
                Citizenship = "Mexicana",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true
            });
        }
    }
}
