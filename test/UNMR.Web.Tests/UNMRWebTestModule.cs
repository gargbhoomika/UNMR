using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using UNMR.EntityFrameworkCore;
using UNMR.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace UNMR.Web.Tests
{
    [DependsOn(
        typeof(UNMRWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class UNMRWebTestModule : AbpModule
    {
        public UNMRWebTestModule(UNMREntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(UNMRWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(UNMRWebMvcModule).Assembly);
        }
    }
}