using System.Threading.Tasks;
using Abp.Application.Services;
using NicoDeWet.WebApi.Authorization.Accounts.Dto;

namespace NicoDeWet.WebApi.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
