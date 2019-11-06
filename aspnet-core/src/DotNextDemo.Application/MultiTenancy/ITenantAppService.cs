using Abp.Application.Services;
using Abp.Application.Services.Dto;
using DotNextDemo.MultiTenancy.Dto;

namespace DotNextDemo.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

