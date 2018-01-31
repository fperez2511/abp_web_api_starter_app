using Abp.MultiTenancy;
using NicoDeWet.WebApi.Authorization.Users;

namespace NicoDeWet.WebApi.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
