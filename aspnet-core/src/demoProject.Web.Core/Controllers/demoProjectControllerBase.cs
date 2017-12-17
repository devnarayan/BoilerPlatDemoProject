using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace demoProject.Controllers
{
    public abstract class demoProjectControllerBase: AbpController
    {
        protected demoProjectControllerBase()
        {
            LocalizationSourceName = demoProjectConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
