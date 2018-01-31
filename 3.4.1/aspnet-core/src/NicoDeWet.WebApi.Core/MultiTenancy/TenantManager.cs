using Abp.Application.Features;
using Abp.Domain.Repositories;
using Abp.MultiTenancy;
using NicoDeWet.WebApi.Authorization.Users;
using NicoDeWet.WebApi.Editions;

namespace NicoDeWet.WebApi.MultiTenancy
{
    public class TenantManager : AbpTenantManager<Tenant, User>
    {
        public TenantManager(
            IRepository<Tenant> tenantRepository, 
            IRepository<TenantFeatureSetting, long> tenantFeatureRepository, 
            EditionManager editionManager,
            IAbpZeroFeatureValueStore featureValueStore) 
            : base(
                tenantRepository, 
                tenantFeatureRepository, 
                editionManager,
                featureValueStore)
        {
        }
    }
}
