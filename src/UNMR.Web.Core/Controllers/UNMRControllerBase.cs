using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace UNMR.Controllers
{
    public abstract class UNMRControllerBase: AbpController
    {
        protected UNMRControllerBase()
        {
            LocalizationSourceName = UNMRConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
