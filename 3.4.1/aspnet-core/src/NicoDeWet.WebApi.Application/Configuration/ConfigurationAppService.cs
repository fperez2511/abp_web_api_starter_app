using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using NicoDeWet.WebApi.Configuration.Dto;

namespace NicoDeWet.WebApi.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : WebApiAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
