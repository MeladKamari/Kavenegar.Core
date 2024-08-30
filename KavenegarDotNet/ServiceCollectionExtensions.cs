using System;
using Microsoft.Extensions.DependencyInjection;

namespace KavenegarDotNet
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddKaveNegar(this IServiceCollection services, Action<KaveNegarConfig> configureOptions)
        {
            var config = new KaveNegarConfig();
            configureOptions(config);
            services.AddSingleton<IKaveNegar>(provider => new KaveNegar(config));
            return services;
        }
    }
}