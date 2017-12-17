using System.Threading.Tasks;
using Abp.Application.Services;
using demoProject.Authorization.Accounts.Dto;

namespace demoProject.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
