using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using NicoDeWet.WebApi.Authorization;

namespace NicoDeWet.WebApi
{
    [DependsOn(
        typeof(WebApiCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class WebApiApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<WebApiAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(WebApiApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
