using Abp.Application.Services;
using Abp.Application.Services.Dto;
using demoProject.MultiTenancy.Dto;

namespace demoProject.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
