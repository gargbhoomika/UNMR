using System.Threading.Tasks;
using UNMR.Configuration.Dto;

namespace UNMR.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
