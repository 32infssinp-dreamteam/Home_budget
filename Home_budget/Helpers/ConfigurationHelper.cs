using System.Configuration;
using System.Reflection;

namespace Home_budget.Helpers
{
    public static class ConfigurationHelper
    {
        public static string GetConfigurationValue(string key)
        {
            var configFilePath = Assembly.GetEntryAssembly().Location;
            var appSettings = ConfigurationManager.OpenExeConfiguration(configFilePath);
            var settings = appSettings.AppSettings.Settings;

            var value = settings[key].Value;

            return value;
        }
    }
}