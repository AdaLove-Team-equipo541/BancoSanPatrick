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

            builder.HasData(
                new ApplicationUser
                    {
                    Id = "383a363b-fa7e-4f40-9727-9aec581f3901",
                    Email = "customer@mail.com",
                    NormalizedEmail = "CUSTOMER@MAIL.COM",
                    UserName = "customer@mail.com",
                    NormalizedUserName = "CUSTOMER@MAIL.COM",
                    PasswordHash = hasher.HashPassword(null, "12345"),
                    PhoneNumber = "7352096019",
                    FirstName = "Elon",
                    MiddleName = "Musk",
                    LastName = "",
                    Citizenship = "Sudafricano",
                    EmailConfirmed = true,
                    PhoneNumberConfirmed = true
                },
                new ApplicationUser
                {
                    Id = "383a363b-fa7e-4f40-9727-9aec581f3922",
                    Email = "employee@mail.com",
                    NormalizedEmail = "EMPLOYEE@MAIL.COM",
                    UserName = "employee@mail.com",
                    NormalizedUserName = "EMPLOYEE@MAIL.COM",
                    PasswordHash = hasher.HashPassword(null, "12345"),
                    PhoneNumber = "7352096019",
                    FirstName = "Jeff",
                    MiddleName = "Bezos",
                    LastName = "",
                    Citizenship = "Estadounidense",
                    EmailConfirmed = true,
                    PhoneNumberConfirmed = true
                }
            );
        }
    }
}
