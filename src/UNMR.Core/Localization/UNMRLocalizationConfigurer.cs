using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace UNMR.Localization
{
    public static class UNMRLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(UNMRConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(UNMRLocalizationConfigurer).GetAssembly(),
                        "UNMR.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
