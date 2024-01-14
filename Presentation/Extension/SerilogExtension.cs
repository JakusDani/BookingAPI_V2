using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;
using Serilog;

namespace Presentation.Extension;
public static class SerilogExtension
{
    public static IHostBuilder SerilogConfig(this ConfigureHostBuilder configureHostBuilder)
    {
        return configureHostBuilder.UseSerilog((context, configuration) =>
            configuration.ReadFrom.Configuration(context.Configuration));
    }
}