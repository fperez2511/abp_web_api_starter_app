using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using NicoDeWet.WebApi.Authorization;
using NicoDeWet.WebApi.Authorization.Roles;
using NicoDeWet.WebApi.Authorization.Users;
using NicoDeWet.WebApi.Editions;
using NicoDeWet.WebApi.MultiTenancy;

namespace NicoDeWet.WebApi.Identity
{
    public static class IdentityRegistrar
    {
        public static IdentityBuilder Register(IServiceCollection services)
        {
            services.AddLogging();

            return services.AddAbpIdentity<Tenant, User, Role>()
                .AddAbpTenantManager<TenantManager>()
                .AddAbpUserManager<UserManager>()
                .AddAbpRoleManager<RoleManager>()
                .AddAbpEditionManager<EditionManager>()
                .AddAbpUserStore<UserStore>()
                .AddAbpRoleStore<RoleStore>()
                .AddAbpLogInManager<LogInManager>()
                .AddAbpSignInManager<SignInManager>()
                .AddAbpSecurityStampValidator<SecurityStampValidator>()
                .AddAbpUserClaimsPrincipalFactory<UserClaimsPrincipalFactory>()
                .AddPermissionChecker<PermissionChecker>()
                .AddDefaultTokenProviders();
        }
    }
}
