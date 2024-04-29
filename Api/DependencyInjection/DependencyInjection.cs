using Api.Repositories;

namespace Api.DependencyInjection;

public static class DependencyInjection
{
    public static IServiceCollection AddDependencyInjection(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<IResumeRepository, ResumeRepository>();

        return services;
    }
}