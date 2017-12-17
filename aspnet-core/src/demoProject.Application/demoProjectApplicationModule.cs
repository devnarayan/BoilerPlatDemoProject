using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using demoProject.Authorization;

namespace demoProject
{
    [DependsOn(
        typeof(demoProjectCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class demoProjectApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<demoProjectAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(demoProjectApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(cfg =>
            {
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg.AddProfiles(thisAssembly);
            });
        }
    }
}
