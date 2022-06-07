using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SanPatrick.Identity.Configurations
{
    public class UserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "770a289f-e1be-4cfe-93e7-d70fbd5297a2",
                    UserId = "383a363b-fa7e-4f40-9727-9aec581f3901"
                },
                 new IdentityUserRole<string>
                 {
                     RoleId = "770a289f-e1be-4cfe-93e7-d70fbd5297a3",
                     UserId = "383a363b-fa7e-4f40-9727-9aec581f3922"
                 }
            );
        }
    }
}
