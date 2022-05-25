using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SanPatrick.Application.Enums;

namespace SanPatrick.Identity.Configurations
{
    public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id = "770a289f-e1be-4cfe-93e7-d70fbd5297a2",
                    Name = Roles.BasicCustomer.ToString(),
                    NormalizedName = Roles.BasicCustomer.ToString()
                }
            ); ;
        }
    }
}
