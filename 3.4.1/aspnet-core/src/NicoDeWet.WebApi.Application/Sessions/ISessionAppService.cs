using System.Threading.Tasks;
using Abp.Application.Services;
using NicoDeWet.WebApi.Sessions.Dto;

namespace NicoDeWet.WebApi.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
