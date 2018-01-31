using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using NicoDeWet.WebApi.MultiTenancy;

namespace NicoDeWet.WebApi.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}
