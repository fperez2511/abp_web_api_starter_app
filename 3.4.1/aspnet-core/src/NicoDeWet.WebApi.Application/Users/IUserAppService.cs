using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using NicoDeWet.WebApi.Roles.Dto;
using NicoDeWet.WebApi.Users.Dto;

namespace NicoDeWet.WebApi.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
