using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using demoProject.Roles.Dto;

namespace demoProject.Roles
{
    public interface IRoleAppService : IAsyncCrudAppService<RoleDto, int, PagedResultRequestDto, CreateRoleDto, RoleDto>
    {
        Task<ListResultDto<PermissionDto>> GetAllPermissions();
    }
}
