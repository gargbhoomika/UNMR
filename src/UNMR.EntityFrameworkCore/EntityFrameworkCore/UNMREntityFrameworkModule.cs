using Abp.EntityFrameworkCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Zero.EntityFrameworkCore;
using UNMR.EntityFrameworkCore.Seed;

namespace UNMR.EntityFrameworkCore
{
    [DependsOn(
        typeof(UNMRCoreModule), 
        typeof(AbpZeroCoreEntityFrameworkCoreModule))]
    public class UNMREntityFrameworkModule : AbpModule
    {
        /* Used it tests to skip dbcontext registration, in order to use in-memory database of EF Core */
        public bool SkipDbContextRegistration { get; set; }

        public bool SkipDbSeed { get; set; }

        public override void PreInitialize()
        {
            if (!SkipDbContextRegistration)
            {
                Configuration.Modules.AbpEfCore().AddDbContext<UNMRDbContext>(options =>
                {
                    if (options.ExistingConnection != null)
                    {
                        UNMRDbContextConfigurer.Configure(options.DbContextOptions, options.ExistingConnection);
                    }
                    else
                    {
                        UNMRDbContextConfigurer.Configure(options.DbContextOptions, options.ConnectionString);
                    }
                });
            }
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(UNMREntityFrameworkModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            if (!SkipDbSeed)
            {
                SeedHelper.SeedHostDb(IocManager);
            }
        }
    }
}
