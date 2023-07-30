using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using UNMR.Configuration.Dto;

namespace UNMR.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : UNMRAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
