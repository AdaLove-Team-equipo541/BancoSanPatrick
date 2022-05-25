using Microsoft.AspNetCore.Identity;
using SanPatrick.Application.Enums;
using SanPatrick.Identity.Models;

namespace SanPatrick.Identity.Seeds
{
    public static class DefaultBasicCustomerUser
    {
        public static async Task SeedAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            var defaultUser = new ApplicationUser
            {
                Id = Guid.NewGuid().ToString(),
                Email = "basic@mail.com",
                FirstName = "Jose",
                MiddleName = "Luis",
                LastName = "Sandoval",
                Citizenship = "Mexicana",
                EmailConfirmed= true,
                PhoneNumberConfirmed = true
            };

            if(userManager.Users.All(p => p.Id != defaultUser.Id))
            {
                var user = userManager.FindByEmailAsync(defaultUser.Email);
                if(user == null)
                {
                    await userManager.CreateAsync(defaultUser, "12345");
                    await userManager.AddToRoleAsync(defaultUser, Roles.BasicCustomer.ToString());
                }
            }
        }
    }
}
