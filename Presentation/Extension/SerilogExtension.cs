using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Serilog;
using Serilog.Core;
using Serilog.Formatting.Compact;

namespace Presentation.Extension;
public static class SerilogExtension
{
    public static ILoggingBuilder SerilogConfig(this ILoggingBuilder loggingBuilder)
    {
        string currentDir = AppDomain.CurrentDomain.BaseDirectory;
        IConfigurationRoot config = new ConfigurationBuilder()
            .SetBasePath(currentDir)
            .AddJsonFile("appsettings.json")
            .Build();

        string loggerPath = currentDir + "Logs/log.json";
        Logger logger = new LoggerConfiguration()
            .ReadFrom.Configuration(config)
            .WriteTo.File(new CompactJsonFormatter(),
                loggerPath,
                rollingInterval: RollingInterval.Day,
                retainedFileCountLimit: 60)
            .CreateLogger();

        return loggingBuilder.AddSerilog(logger);
    }
}