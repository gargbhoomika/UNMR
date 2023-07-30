using UNMR.Debugging;

namespace UNMR
{
    public class UNMRConsts
    {
        public const string LocalizationSourceName = "UNMR";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "c072068e008145e39669968b37d61e22";
    }
}
