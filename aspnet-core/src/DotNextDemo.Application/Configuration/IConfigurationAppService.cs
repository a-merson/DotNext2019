using System.Threading.Tasks;
using DotNextDemo.Configuration.Dto;

namespace DotNextDemo.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
