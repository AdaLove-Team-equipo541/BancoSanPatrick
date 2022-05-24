using Microsoft.AspNetCore.Identity;
using SanPatrick.Application.Enums;
using SanPatrick.Identity.Models;

namespace SanPatrick.Identity.Seeds
{
    public static class DefaultRoles
    {
        public static async Task SeedAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            await roleManager.CreateAsync(new IdentityRole(Roles.BasicCustomer.ToString()));
        }
    }
}
