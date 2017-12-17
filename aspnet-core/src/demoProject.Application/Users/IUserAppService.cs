using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using demoProject.Roles.Dto;
using demoProject.Users.Dto;

namespace demoProject.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
