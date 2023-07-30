using System.Threading.Tasks;
using Abp.Application.Services;
using UNMR.Authorization.Accounts.Dto;

namespace UNMR.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
