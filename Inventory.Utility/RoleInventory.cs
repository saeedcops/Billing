using Inventory.Models;
using Microsoft.AspNetCore.Identity;

namespace Inventory.Utility
{
    public class RoleInventory : IRoleInventory
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public RoleInventory(UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task AddRoleAsync(string appUserId)
        {
            var user = await _userManager.FindByIdAsync(appUserId);
            var roles = _roleManager.Roles;
            List<string> roleString = new List<string>();
            if(user != null)
            {
                foreach (var role in roles)
                {
                    roleString.Add(role.Name);
                }

                await _userManager.AddToRolesAsync(user, roleString);
            }
        }

        public async Task CreateNewRoleAsync()
        {
            Type t = typeof(TopMenu);
            foreach (Type classObj in t.GetNestedTypes())
            {
                foreach (var field in classObj.GetFields())
                {
                    if (field.Name.Contains("RoleName"))
                    {
                        if(!await _roleManager.RoleExistsAsync(field.Name))
                        {
                            await _roleManager.CreateAsync(new IdentityRole(field.Name));
                        }
                    }
                }
            }
        }
    }
}
