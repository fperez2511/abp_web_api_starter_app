using Abp.Authorization;
using NicoDeWet.WebApi.Authorization.Roles;
using NicoDeWet.WebApi.Authorization.Users;

namespace NicoDeWet.WebApi.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
