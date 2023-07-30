using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using UNMR.Authorization;

namespace UNMR
{
    [DependsOn(
        typeof(UNMRCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class UNMRApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<UNMRAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(UNMRApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
