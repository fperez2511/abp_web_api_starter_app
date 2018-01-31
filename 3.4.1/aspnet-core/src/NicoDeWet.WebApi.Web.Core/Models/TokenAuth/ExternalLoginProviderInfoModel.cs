using Abp.AutoMapper;
using NicoDeWet.WebApi.Authentication.External;

namespace NicoDeWet.WebApi.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
