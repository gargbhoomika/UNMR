using System.Collections.Generic;

namespace UNMR.Authentication.External
{
    public interface IExternalAuthConfiguration
    {
        List<ExternalLoginProviderInfo> Providers { get; }
    }
}
