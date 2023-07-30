using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using UNMR.Configuration;
using UNMR.EntityFrameworkCore;
using UNMR.Migrator.DependencyInjection;

namespace UNMR.Migrator
{
    [DependsOn(typeof(UNMREntityFrameworkModule))]
    public class UNMRMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public UNMRMigratorModule(UNMREntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(UNMRMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                UNMRConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(UNMRMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
