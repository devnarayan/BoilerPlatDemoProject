using System.Threading.Tasks;
using demoProject.Configuration.Dto;

namespace demoProject.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
