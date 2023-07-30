using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Abp.Authorization;
using UNMR.Authorization.Roles;
using UNMR.Authorization.Users;
using UNMR.MultiTenancy;
using Microsoft.Extensions.Logging;
using Abp.Domain.Uow;

namespace UNMR.Identity
{
    public class SecurityStampValidator : AbpSecurityStampValidator<Tenant, Role, User>
    {
        public SecurityStampValidator(
            IOptions<SecurityStampValidatorOptions> options,
            SignInManager signInManager,
            ISystemClock systemClock,
            ILoggerFactory loggerFactory,
            IUnitOfWorkManager unitOfWorkManager)
            : base(options, signInManager, systemClock, loggerFactory, unitOfWorkManager)
        {
        }
    }
}
