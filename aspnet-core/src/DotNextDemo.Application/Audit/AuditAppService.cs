using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Auditing;
using Abp.Authorization;
using Abp.Domain.Repositories;
using Abp.Linq;
using Abp.Linq.Extensions;
using DotNextDemo.Audit.Dto;
using DotNextDemo.Authorization;

namespace DotNextDemo.Audit
{
    [AbpAuthorize(PermissionNames.Pages_Audit)]
    public class AuditAppService : ApplicationService, IAuditAppService
    {
        private readonly IRepository<AuditLog, long> _repository;
        private readonly IAsyncQueryableExecuter _asyncQueryableExecuter;

        public AuditAppService(IRepository<AuditLog, long> repository,
            IAsyncQueryableExecuter asyncQueryableExecuter)
        {
            _repository = repository;
            _asyncQueryableExecuter = asyncQueryableExecuter;
        }

        public async Task<PagedResultDto<AuditDto>> GetAll(PagedResultRequestDto input)
        {
            var query = _repository.GetAll();
            var totalCount = await _asyncQueryableExecuter.CountAsync(query);

            query = query.PageBy(input);

            var entities = await _asyncQueryableExecuter.ToListAsync(query);

            return new PagedResultDto<AuditDto>(
                totalCount,
                entities.Select(ObjectMapper.Map<AuditDto>).ToList()
            );
        }
    }
}
