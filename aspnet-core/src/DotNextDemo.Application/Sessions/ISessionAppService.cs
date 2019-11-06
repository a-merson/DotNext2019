using System.Threading.Tasks;
using Abp.Application.Services;
using DotNextDemo.Sessions.Dto;

namespace DotNextDemo.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
