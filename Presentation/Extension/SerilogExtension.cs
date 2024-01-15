using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Serilog;
using Serilog.Core;

namespace Presentation.Extension;
public static class SerilogExtension
{
    public static ILoggingBuilder SerilogConfig(this ILoggingBuilder loggingBuilder)
    {
        string currentDir = AppDomain.CurrentDomain.BaseDirectory
;
        IConfigurationRoot config = new ConfigurationBuilder()
            .SetBasePath(currentDir)
            .AddJsonFile("appsettings.json")
            .Build();

        Logger logger = new LoggerConfiguration()
            .ReadFrom.Configuration(config)
            .CreateLogger();

        return loggingBuilder.AddSerilog(logger);
    }
}