using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Soenneker.Quark.Headings.Abstract;

namespace Soenneker.Quark.Headings.Registrars;

/// <summary>
/// A Blazor UI wrapper for the typography component, Heading.
/// </summary>
public static class HeadingRegistrar
{
    /// <summary>
    /// Adds <see cref="IHeading"/> as a scoped service. <para/>
    /// </summary>
    public static IServiceCollection AddHeadingAsScoped(this IServiceCollection services)
    {
        services.TryAddScoped<IHeading, Heading>();

        return services;
    }
}
