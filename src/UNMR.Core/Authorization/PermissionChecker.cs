using Abp.Authorization;
using UNMR.Authorization.Roles;
using UNMR.Authorization.Users;

namespace UNMR.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
