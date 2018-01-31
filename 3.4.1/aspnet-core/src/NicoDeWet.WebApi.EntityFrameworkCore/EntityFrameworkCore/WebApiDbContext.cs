using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using NicoDeWet.WebApi.Authorization.Roles;
using NicoDeWet.WebApi.Authorization.Users;
using NicoDeWet.WebApi.MultiTenancy;

namespace NicoDeWet.WebApi.EntityFrameworkCore
{
    public class WebApiDbContext : AbpZeroDbContext<Tenant, Role, User, WebApiDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public WebApiDbContext(DbContextOptions<WebApiDbContext> options)
            : base(options)
        {
        }
    }
}
