using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using DotNextDemo.Audit.Dto;

namespace DotNextDemo.Audit
{
    public interface IAuditAppService : IApplicationService
    {
        Task<PagedResultDto<AuditDto>> GetAll(PagedResultRequestDto input);
    }
}