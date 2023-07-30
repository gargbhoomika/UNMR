using Xunit;

namespace UNMR.Tests
{
    public sealed class MultiTenantFactAttribute : FactAttribute
    {
        public MultiTenantFactAttribute()
        {
            if (!UNMRConsts.MultiTenancyEnabled)
            {
                Skip = "MultiTenancy is disabled.";
            }
        }
    }
}
