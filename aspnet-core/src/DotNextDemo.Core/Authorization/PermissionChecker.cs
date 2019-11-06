using Abp.Authorization;
using DotNextDemo.Authorization.Roles;
using DotNextDemo.Authorization.Users;

namespace DotNextDemo.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
