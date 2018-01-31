using Abp.Application.Services;
using Abp.Application.Services.Dto;
using NicoDeWet.WebApi.MultiTenancy.Dto;

namespace NicoDeWet.WebApi.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
