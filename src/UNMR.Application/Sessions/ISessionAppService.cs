using System.Threading.Tasks;
using Abp.Application.Services;
using UNMR.Sessions.Dto;

namespace UNMR.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
