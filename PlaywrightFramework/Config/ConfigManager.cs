using Microsoft.Extensions.Configuration;

namespace PlaywrightFramework.Config
{
    public class ConfigManager
    {
        private static readonly Lazy<IConfigurationRoot> _lazy =
         new(() => new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build());

        public static PagePathOptions PagePaths => _lazy.Value.GetSection("UiClient:PagePaths").Get<PagePathOptions>();
        public static string BaseUrl => _lazy.Value.GetSection("UiClient:BaseUrl").Get<string>();

        static ConfigManager() { }

        private ConfigManager() { }
    }
}
