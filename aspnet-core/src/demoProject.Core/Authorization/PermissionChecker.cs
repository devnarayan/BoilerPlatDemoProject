using Abp.Authorization;
using demoProject.Authorization.Roles;
using demoProject.Authorization.Users;

namespace demoProject.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
