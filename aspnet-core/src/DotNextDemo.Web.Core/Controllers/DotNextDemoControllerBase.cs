using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace DotNextDemo.Controllers
{
    public abstract class DotNextDemoControllerBase: AbpController
    {
        protected DotNextDemoControllerBase()
        {
            LocalizationSourceName = DotNextDemoConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
