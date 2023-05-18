using Microsoft.Extensions.DependencyInjection;
using Scrutor.Repro;

internal static class ScanExtensions
{
    internal static IServiceCollection AutoRegister(this IServiceCollection services)
    {
        services.Scan(scan => scan.FromApplicationDependencies()
            .AddClasses(classes => classes.AssignableTo<ISayHelloToTheWorld>()).As<ISayHelloToTheWorld>());
        return services;
    }
}