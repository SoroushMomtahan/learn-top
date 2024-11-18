namespace LearnTop.Api.Extensions;

public static class ConfigurationExtension
{
    public static IConfigurationManager AddConfigurationFiles(
        this IConfigurationManager configuration,
        params string[] modules)
    {
        foreach (string module in modules)
        {
            configuration.AddJsonFile($"modules.{module}.json", false, true);
            configuration.AddJsonFile($"modules.{module}.Development.json", true, true);
        }
        
        return configuration;
    }
}
