using Microsoft.AspNetCore.Identity;
using NeoTMSWebApp.Models;

namespace NeoTMSWebApp.Data;

public static class ContextSeed
{
    public static async Task SeedRolesAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
    {
        //Seed Roles
        await roleManager.CreateAsync(new IdentityRole(Enums.Roles.SuperAdmin.ToString()));
        await roleManager.CreateAsync(new IdentityRole(Enums.Roles.Admin.ToString()));
        await roleManager.CreateAsync(new IdentityRole(Enums.Roles.Manager.ToString()));
        await roleManager.CreateAsync(new IdentityRole(Enums.Roles.HRExecutive.ToString()));
        await roleManager.CreateAsync(new IdentityRole(Enums.Roles.Trainer.ToString()));
        await roleManager.CreateAsync(new IdentityRole(Enums.Roles.Trainee.ToString()));
    }
}
