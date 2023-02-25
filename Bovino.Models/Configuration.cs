using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Bovino.Models
{
    public class ConfigurationHelper
    {
        public static IConfiguration Configuration { get; set; }

        public static IServiceCollection Services { get; set; }

        public static TService GetService<TService>()
        {
            return Services.BuildServiceProvider().GetService<TService>();
        }

    }
}
