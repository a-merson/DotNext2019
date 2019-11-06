using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using DotNextDemo.Configuration.Dto;

namespace DotNextDemo.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : DotNextDemoAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
