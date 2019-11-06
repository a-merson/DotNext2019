using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using DotNextDemo.Configuration;

namespace DotNextDemo.Web.Host.Startup
{
    [DependsOn(
       typeof(DotNextDemoWebCoreModule))]
    public class DotNextDemoWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public DotNextDemoWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(DotNextDemoWebHostModule).GetAssembly());
        }
    }
}
