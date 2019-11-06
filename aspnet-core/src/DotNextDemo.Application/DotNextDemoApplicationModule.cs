using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using DotNextDemo.Authorization;

namespace DotNextDemo
{
    [DependsOn(
        typeof(DotNextDemoCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class DotNextDemoApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<DotNextDemoAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(DotNextDemoApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
