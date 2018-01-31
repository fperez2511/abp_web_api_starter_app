using System.Threading.Tasks;
using NicoDeWet.WebApi.Configuration.Dto;

namespace NicoDeWet.WebApi.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
