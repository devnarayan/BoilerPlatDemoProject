using System.Threading.Tasks;
using Abp.Application.Services;
using demoProject.Sessions.Dto;

namespace demoProject.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
