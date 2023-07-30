using Abp.Application.Services;
using UNMR.MultiTenancy.Dto;

namespace UNMR.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

