using System;
using System.Text;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Threading.BackgroundWorkers;

namespace Plugin
{
    public class PluginModule : AbpModule
    {
        public PluginModule()
        {
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PluginModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            var manager = IocManager.Resolve<IBackgroundWorkerManager>();
            manager.Add(IocManager.Resolve<PluginBackgroundWorker>());
        }
    }
}
