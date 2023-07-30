using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using UNMR.Configuration;

namespace UNMR.Web.Host.Startup
{
    [DependsOn(
       typeof(UNMRWebCoreModule))]
    public class UNMRWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public UNMRWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(UNMRWebHostModule).GetAssembly());
        }
    }
}
